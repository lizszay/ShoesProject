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
                        bool stayInMenu = true;

                        while (stayInMenu && !exitProgram)
                        {
                            stayInMenu = false; 

                            using (var formMenu = new FormMenu(
                                formLogin.CurrentUser,
                                formLogin.IsGuest))
                            {
                                var menuResult = formMenu.ShowDialog();

                                if (menuResult == DialogResult.Yes) //продукты
                                {
                                    using (var formProducts = new FormProducts(
                                        formLogin.CurrentUser,
                                        formLogin.IsGuest))
                                    {
                                        var productsResult = formProducts.ShowDialog();

                                        if (productsResult == DialogResult.Abort)
                                        {
                                            stayInMenu = true;
                                        }
                                        else if (productsResult == DialogResult.Cancel)
                                        {
                                            // Нажали "Выход" - возвращение к логину
                                            // stayInMenu останется false - выход из цикла меню
                                        }
                                        else
                                        {
                                            exitProgram = true;  // Выйти из программы
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
                                            stayInMenu = true;
                                        }
                                        else if (ordersResult == DialogResult.Cancel)
                                        {

                                        }
                                        else
                                        {
                                            exitProgram = true;
                                        }
                                    }
                                }
                                else if (menuResult == DialogResult.Cancel)
                                {

                                }
                                else
                                {
                                    exitProgram = true; 
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