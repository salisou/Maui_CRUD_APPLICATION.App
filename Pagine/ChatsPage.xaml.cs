using Maui_CRUD_APPLICATION.Models;
using System.Collections.ObjectModel;

namespace Maui_CRUD_APPLICATION.Pagine;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
		InitializeComponent();
		Chats = new ObservableCollection<ChatModel>(LoadChats());

		BindingContext = this;
	}


	public ObservableCollection<ChatModel> Chats { get; set; }
	private static IEnumerable<ChatModel> LoadChats()
	{
		return new List<ChatModel>
		{
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "è solo un test!", 0),
			new ChatModel("male_man_people.svg", "Ciao sono 2",		DateTime.Now, "Ora so che funziona bene", 10),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "So ch'è figa!", 11),
			new ChatModel("male_man_people.svg", "Ciao sono 3",		DateTime.Now, "Sto facendo prova", 5),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Vedo come funziona Maui", 10),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Capisco già", 3),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Si che la mia app funziona benissimo", 1),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Sono molto contento", 2),
			new ChatModel("male_man_people.svg", "Ciao sono 2",		DateTime.Now.AddDays(-2), "Bravo Moussa", 10),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Grazie mille", 10),
			new ChatModel("male_man_people.svg", "Ciao sono 3",		DateTime.Now.AddDays(-2), "Mi puoi fare vedere come si fa?!", 10),
			new ChatModel("male_man_people.svg", "Ciao sono 1",		DateTime.Now.AddDays(-2), "Si certo", 5)
		};
	}
}