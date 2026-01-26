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
                        // Цикл для главного меню (чтобы можно было возвращаться из товаров/заказов)
                        bool stayInMenu = true;

                        while (stayInMenu && !exitProgram)
                        {
                            stayInMenu = false; // сбрасываем флаг

                            using (var formMenu = new FormMenu(
                                formLogin.CurrentUser,
                                formLogin.IsGuest))
                            {
                                var menuResult = formMenu.ShowDialog();

                                if (menuResult == DialogResult.Yes) // Товары
                                {
                                    using (var formProducts = new FormProducts(
                                        formLogin.CurrentUser,
                                        formLogin.IsGuest))
                                    {
                                        var productsResult = formProducts.ShowDialog();

                                        if (productsResult == DialogResult.Abort)
                                        {
                                            // Нажали "Назад" - остаемся в меню
                                            stayInMenu = true;
                                        }
                                        else if (productsResult == DialogResult.Cancel)
                                        {
                                            // Нажали "Выход" - возвращаемся к логину
                                            // stayInMenu останется false - выйдем из цикла меню
                                        }
                                        else
                                        {
                                            exitProgram = true; // Выйти из программы
                                        }
                                    }
                                }
                                else if (menuResult == DialogResult.No) // Заказы
                                {
                                    using (var formOrders = new FormOrders(
                                        formLogin.CurrentUser,
                                        formLogin.IsGuest))
                                    {
                                        var ordersResult = formOrders.ShowDialog();

                                        if (ordersResult == DialogResult.Abort)
                                        {
                                            // Нажали "Назад" - остаемся в меню
                                            stayInMenu = true;
                                        }
                                        else if (ordersResult == DialogResult.Cancel)
                                        {
                                            // Нажали "Выход" - возвращаемся к логину
                                            // stayInMenu останется false - выйдем из цикла меню
                                        }
                                        else
                                        {
                                            exitProgram = true; // Выйти из программы
                                        }
                                    }
                                }
                                else if (menuResult == DialogResult.Cancel)
                                {
                                    // Нажали "Выход" в меню - возвращаемся к логину
                                    // stayInMenu останется false - выйдем из цикла меню
                                }
                                else
                                {
                                    exitProgram = true; // Выйти из программы
                                }
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