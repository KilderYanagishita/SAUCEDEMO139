using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; //objeto dop selenium

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            //Instanciando o ChromeDriver atraves do WebDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); // Instanciou o selenium com o chromedriver
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); //encerou o selenium
        }
        [Given(@"que acesso a pagina inicial do site")]
        public void DadoQueAcessoAPaginaInicialDoSite()
        {
            _scenarioContext.Pending();
        }

        [When(@"preecho o usuario como ""(.*)""")]
        public void QuandoPreechoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]
        public void QuandoASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto no ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoNoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}