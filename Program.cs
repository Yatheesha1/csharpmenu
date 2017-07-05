using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
public class MenuTest1 :Form
{
	private MainMenu mainMenu;
	public MenuTest1()
	{
		mainMenu = new MainMenu();
		MenuItem File = mainMenu.MenuItems.Add("&File");
		File .MenuItems.Add(new MenuItem("&New"));
		File .MenuItems.Add(new MenuItem("&Open"));
		File .MenuItems.Add(new MenuItem("&Exit"));
		this.Menu=mainMenu;
		MenuItem About = mainMenu.MenuItems.Add("&About");
		About.MenuItems.Add(new MenuItem("&About"));
		this.Menu=mainMenu;
		mainMenu.GetForm().BackColor = Color.Indigo;
	}
	public static void Main(string[] args)
	{
		Application.Run(new MenuTest1());
	}
}