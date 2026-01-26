namespace ShoesProject
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			bool exitProgram = false;

			while (!exitProgram)
			{
				using (var formLogin = new FormLogin())
				{
					if (formLogin.ShowDialog() == DialogResult.OK)
					{
                        // 2. Главное меню (после успешного входа)
                        using (var formMenu = new FormMenu(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            // Ждем пока пользователь выберет что-то в меню
                            if (formMenu.ShowDialog() == DialogResult.Cancel)
                            {
                                continue; // Вернуться к форме логина
                            }
                            else
                            {
                                exitProgram = true; // Выйти из программы
                            }
                        }
					}
					else
					{
						exitProgram = true;
					}
				}
			}
		}
	}
}