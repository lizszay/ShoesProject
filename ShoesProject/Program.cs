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
                        // 2. Главное меню
                        using (var formMenu = new FormMenu(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            var menuResult = formMenu.ShowDialog();

                            if (menuResult == DialogResult.OK)
                            {
                                // Пользователь выбрал "Товары"
                                using (var formProducts = new FormProducts(
                                    formLogin.CurrentUser,
                                    formLogin.IsGuest))
                                {
                                    if (formProducts.ShowDialog() == DialogResult.Cancel)
                                    {
                                        continue; // Вернуться к меню
                                    }
                                    else
                                    {
                                        exitProgram = true; // Выйти из программы
                                    }
                                }
                            }
                            else if (menuResult == DialogResult.Yes)
                            {
                                // Пользователь выбрал "Мои заказы"
                                using (var formOrders = new FormOrders(
                                    formLogin.CurrentUser,
                                    formLogin.IsGuest))
                                {
                                    if (formOrders.ShowDialog() == DialogResult.Cancel)
                                    {
                                        continue; // Вернуться к меню
                                    }
                                    else
                                    {
                                        exitProgram = true; // Выйти из программы
                                    }
                                }
                            }
                            else if (menuResult == DialogResult.Cancel)
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
                        exitProgram = true; // Нажали Отмена в форме логина
                    }
                }
			}
		}
	}
}