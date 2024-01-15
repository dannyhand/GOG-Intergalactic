using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace GOG_Intergalactic;

public partial class Form1 : Form
{
	private readonly string _connectionString = "Data Source=C:\\ProgramData\\GOG.com\\Galaxy\\storage\\galaxy-2.0.db";

	public Form1()
	{
		InitializeComponent();
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		await using var connection = new SqliteConnection(_connectionString);
		await connection.OpenAsync();

		await using var command = new SqliteCommand(
			"SELECT productId, releaseKey, title FROM LimitedDetails " +
			"JOIN ProductsToReleaseKeys ON LimitedDetails.productId = ProductsToReleaseKeys.gogId",
			connection);
		await using var reader = await command.ExecuteReaderAsync();

		while (await reader.ReadAsync())
		{
			listBox1.Items.Add(new Product((long)reader["productId"], (string)reader["releaseKey"], (string)reader["title"]));
		}
	}

	private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		var product = listBox1.SelectedItem as Product;
		if (product == null)
		{
			shortcutButton.Enabled = false;
			return;
		}

		await using var connection = new SqliteConnection(_connectionString);
		await connection.OpenAsync();

		await using var command = connection.CreateCommand();
		command.CommandText = "SELECT * FROM ProductSettings WHERE gameReleaseKey = $key";
		command.Parameters.AddWithValue("key", product.ReleaseKey);

		await using var reader = await command.ExecuteReaderAsync();
		if (await reader.ReadAsync())
		{
			for (var i = 0; i < productSettings.Items.Count; i++)
			{
				var item = (string)productSettings.Items[i];
				productSettings.SetItemChecked(i, reader[item].ToString() == "1");
			}
		}

		shortcutButton.Enabled = true;
	}

	private async void productSettings_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		var product = listBox1.SelectedItem as Product;
		if (product == null) return;

		var item = productSettings.SelectedItem as string;
		if (string.IsNullOrEmpty(item)) return;

		productSettings.ClearSelected();

		await using var connection = new SqliteConnection(_connectionString);
		await connection.OpenAsync();

		await using var command = connection.CreateCommand();
		command.CommandText = $"UPDATE ProductSettings SET {item} = $value WHERE gameReleaseKey = $key";
		command.Parameters.AddWithValue("key", product.ReleaseKey);
		command.Parameters.AddWithValue("value", e.NewValue == CheckState.Checked);

		await command.ExecuteNonQueryAsync();
	}

	private void shortcutButton_Click(object sender, EventArgs e)
	{
		var product = listBox1.SelectedItem as Product;
		if (product == null) return;

		var exe = Process.GetCurrentProcess().MainModule?.FileName;
		var process = new Process();
		process.StartInfo.FileName = exe;
		process.StartInfo.Arguments = "-s " + product.ProductId;
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.Verb = "runas";

		process.Start();
	}
}

public record Product(long ProductId, string ReleaseKey, string Title);
