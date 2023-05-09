using DesignPatterns.Console.Behavioral.ChainOfResponsibility;
using DesignPatterns.Console.Behavioral.Command;
using DesignPatterns.Console.Behavioral.Iterator;
using DesignPatterns.Console.Behavioral.Observer;
using DesignPatterns.Console.Behavioral.State;
using DesignPatterns.Console.Behavioral.Strategy;
using DesignPatterns.Console.Behavioral.Template;
using DesignPatterns.Console.Creational.Abstract_Factory;
using DesignPatterns.Console.Creational.Builder;
using DesignPatterns.Console.Creational.Factory;
using DesignPatterns.Console.Creational.Prototype;
using DesignPatterns.Console.Creational.Singleton;
using DesignPatterns.Console.Structural.Adapter;
using DesignPatterns.Console.Structural.Bridge;
using DesignPatterns.Console.Structural.Composite;
using DesignPatterns.Console.Structural.Decorator;
using DesignPatterns.Console.Structural.Facade;
using DesignPatterns.Console.Structural.Proxy;

#region Creational Patterns

//Abstract Factory
IFootballFactory superLig = new SuperLigFactory();
FootballWorld footballWorld = new(superLig);
Console.WriteLine(footballWorld.GetFootballTeamColor());
Console.WriteLine(footballWorld.GetTopScorer());

//Builder
ArabaBuilder araba = new KiaBuilder();
ArabaUret uret = new();
uret.Uret(araba);
Console.WriteLine(araba.Araba.ToString());

//Factory Method
BankCreator bankCreator = new();
Bank garantiBank = bankCreator.BankFactory(BankEnum.Garanti);
Console.WriteLine(garantiBank.GetName());

//Prototype
Member member1 = new()
{
    Name = "Burak",
    Surname = "Kural",
    Age = 27
};
Member member2 = (Member)member1.Clone();
Console.WriteLine($"Name : {member2.Name} - Surname : {member2.Surname} - Age : {member2.Age}");

//Singleton
SingletonObject singletonObject1 = SingletonObject.getInstance();
SingletonObject singletonObject2 = SingletonObject.getInstance();
Console.WriteLine(singletonObject1 == singletonObject2);

#endregion Creational Patterns

#region Structual Patterns

//Adapter
IResponse response = new ThirdApiAdapter(new ThirdApiResponse());
Client client = new Client(response);
client.Response();

//Bridge
ITV tv = new SonyTV();
LogitechRemoteControl lrc = new LogitechRemoteControl(tv);
lrc.SetChannelKeyboard(100);

//Composite
MovieContainer thrillerContainer = new();
thrillerContainer.AddMovie(new Thriller(1, "The Silence of the Lambs", "11 Ekim 1991", 8.6));
thrillerContainer.AddMovie(new Thriller(2, "Basic Instinct", "27 Kasım 1992", 7.0));

MovieContainer horrorContainer = new();
horrorContainer.AddMovie(new Horror(3, "Scream", "15 Ağustos 1997", 7.4));

MovieContainer container = new();
container.AddMovie(thrillerContainer);
container.AddMovie(horrorContainer);

container.ShowMovieInfo();

//Decorator
Repository<string> repository = new Repository<string>();
repository.Get(0);
repository.GetAll();
repository.Add("test");
repository.Delete("test");
repository.Update("test");

LoggingRepositoryDecorator<string> loggingRepositoryDecorator = new LoggingRepositoryDecorator<string>(repository);
loggingRepositoryDecorator.Get(0);
loggingRepositoryDecorator.GetAll();
loggingRepositoryDecorator.Add("test");
loggingRepositoryDecorator.Delete("test");
loggingRepositoryDecorator.Update("test");

//Facade
BankingFacade facade = new();
Customer customer1 = new() { IDNo = "1245203836", Fullname = "Ahmet", CustomerNumber = 11243, CashAmount = 3456090.25M };
Customer customer2 = new() { IDNo = "2342342342", Fullname = "Mehmet", CustomerNumber = 123123, CashAmount = 34929272.36M };

facade.SendEFT(customer1, customer2, 12345);
facade.UseCredit(customer2);

//Proxy
ImageGeneratorProxy proxy1 = new ImageGeneratorProxy("c:\\resim1.jpg");
ImageGeneratorProxy proxy2 = new ImageGeneratorProxy("c:\\resim2.jpg");

proxy1.ShowImage();
proxy2.ShowImage();
proxy1.ShowImage();

#endregion Structual Patterns

#region Behavioral Patterns

//ChainOfResponsibility
var withdraw = new Withdraw("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 480000, "TRY", "TR681223154132432141412");

Calisan sorumlu = new Sorumlu();
Calisan yonetici = new Yonetici();
Calisan grupYoneticisi = new GrupYoneticisi();
Calisan direktor = new Direktor();

sorumlu.SiradakiOnayciyiSetEt(yonetici);
yonetici.SiradakiOnayciyiSetEt(grupYoneticisi);
grupYoneticisi.SiradakiOnayciyiSetEt(direktor);


sorumlu.ProcessRequest(withdraw);

//Command
SimpleRemoteControl remoteControl = new();
Light light = new();
LightOnCommand lightOn = new(light);

remoteControl.setCommand(lightOn);
remoteControl.ButtonWasPressed();

//Iterator
DateTimeAggregate date = new DateTimeAggregate();
date.startDate = new DateTime(2023, 05, 01);
date.endDate = DateTime.Now;

IIterator iterator = date.CreateIterator();
while (iterator.Hasdate())
{
    Console.WriteLine(iterator.CurrentDate());
}

//Observer
Product product = new()
{
    ID = 1,
    Name = "Test Ürünü",
    Amount = 100
};
product.AddSubscriber(new SubscriberA());
product.AddSubscriber(new SubscriberB());

product.Amount = 50;

//State
Account account = new Account();
account.WithdrawMoney();
account.PayInterest();

account.ChangeStatus(new GoldAccount());

account.WithdrawMoney();
account.PayInterest();

//Strategy
Serializer srz = new Serializer(new XmlSerializer());

srz.Serialize("");
srz.Deserialize("");

srz = new Serializer(new BinarySerializer());

srz.Serialize("");
srz.Deserialize("");

//Template
Alisveris a1 = new Televizyon();
a1.TemplateMethod();

Console.WriteLine("***********");

Alisveris a2 = new Mobilya();
a2.TemplateMethod();

#endregion Behavioral Patterns