using TCFQ.Repository.Context;

namespace TCFQ.WF.Util
{
    public static class FormsExtensions
    {
        const string DB_CONNECTION_ERROR = "Erro ao testar a conexão com banco de dados";

        public static async Task EnableControlsAsync(this Form form, AppDbContext context, params Control[] controls)
        {
            bool _databaseConnectionSuccessfull = false;
            try
            {
                await Task.Run(async () =>
                {
                    _databaseConnectionSuccessfull = await new Database(context).TestConnectionDB();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{DB_CONNECTION_ERROR}: {ex.Message}", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (controls.Any())
                {
                    foreach (var control in controls)
                    {
                        control.Enabled = _databaseConnectionSuccessfull;
                    }
                }
            }
        }
    }
}
