using InterfaceDemoApp;


Console.WriteLine("Hello, World!");

CustomerDashBoard dashboard = new CustomerDashBoard();

dashboard.show();
dashboard.ShowCustomerProfile();
dashboard.ShowOrderHistory();

IPaymentDetails details = dashboard;
details.Display();

IOrderDetails orderDeatils = dashboard;
orderDeatils.Display();

Stack stack1 = new Stack(4);
Stack stack2 = (Stack)stack1.Clone();  //referce Copy

Stack stack3 = (Stack)stack2.Clone();

