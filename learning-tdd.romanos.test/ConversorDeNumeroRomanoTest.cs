using learning_tdd.romanos.Services;
using NUnit.Framework;

namespace learning_tdd.romanos.test
{
    [TestFixture] // [SetUpFixture] // SetUpFixture faz com que o Setup e o TearDown execute uma vez
    public class ConversorDeNumeroRomanoTest
    {
        private ConversorDeNumeroRomano _romano;

        // TODO: Os números eram representados por sete diferentes símbolos.

        // | I | unus         | 1 (um)           |
        // | V | quinque      | 5 (cinco)        |
        // | X | decem        | 10 (dez)         |
        // | L | quinquaginta | 50 (cinquenta)   |
        // | C | centum       | 100 (cem)        |
        // | D | quingenti    | 500 (quinhentos) |
        // | M | mille        | 1.000 (mil)      |

        // Regras
        // TODO: Algarismos de menor ou igual valor à direita são somados ao algarismo de maior valor.
        // TODO: Algarismos de menor valor à esquerda são subtraídos do algarismo de maior valor.
        // Exemplo: XV representa 15 (10 + 5) 
        // e o número XXVIII representa 28 (10 + 10 + 5 + 1 + 1 + 1). 
        // e o número IX representa 9 (10 - 1). 
        // TODO: Nenhum símbolo pode ser repetido lado a lado por mais de 3 vezes.
        // Exemplo: O número 4 é representado pelo número IV (5 - 1) e não pelo número IIII.

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            _romano = new ConversorDeNumeroRomano();
        }

        //[TearDown]
        //public void RunAfterAnyTests() { }

        #region Primeiro Cenário - Representação dos Algarismos.

        [Test] // , Category("Representação")]
        public void DeveEntenderOSimboloI()
        {
            int numero = _romano.Converte("I");

            Assert.That(1, Is.EqualTo(numero)
                , "O simbolo I não foi reconhecido.");
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloV()
        {
            int numero = _romano.Converte("V");

            Assert.AreEqual(5, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloX()
        {
            int numero = _romano.Converte("X");

            Assert.AreEqual(10, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloL()
        {
            int numero = _romano.Converte("L");

            Assert.AreEqual(50, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloC()
        {
            int numero = _romano.Converte("C");

            Assert.AreEqual(100, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloD()
        {
            int numero = _romano.Converte("D");

            Assert.AreEqual(500, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloM()
        {
            int numero = _romano.Converte("M");

            Assert.AreEqual(1000, numero);
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void DeveEntenderOsSimbolos(string simbolo, int valor)
        {
            int numero = _romano.Converte(simbolo);

            Assert.AreEqual(valor, numero);
        }

        #endregion

        #region Segundo Cenário - Dois símbolos em sequência.

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoII()
        {
            int numero = _romano.Converte("II");

            Assert.AreEqual(2, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoVI()
        {
            int numero = _romano.Converte("VI");

            Assert.AreEqual(6, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoXI()
        {
            int numero = _romano.Converte("XI");

            Assert.AreEqual(11, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoXX()
        {
            int numero = _romano.Converte("XX");

            Assert.AreEqual(20, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLI()
        {
            int numero = _romano.Converte("LI");

            Assert.AreEqual(51, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLV()
        {
            int numero = _romano.Converte("LV");

            Assert.AreEqual(55, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLX()
        {
            int numero = _romano.Converte("LX");

            Assert.AreEqual(60, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoCI()
        {
            int numero = _romano.Converte("CI");

            Assert.AreEqual(101, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoCX()
        {
            int numero = _romano.Converte("CX");

            Assert.AreEqual(110, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoDX()
        {
            int numero = _romano.Converte("DX");

            Assert.AreEqual(510, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoDC()
        {
            int numero = _romano.Converte("DC");

            Assert.AreEqual(600, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoMX()
        {
            int numero = _romano.Converte("MX");

            Assert.AreEqual(1010, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoMD()
        {
            int numero = _romano.Converte("MD");

            Assert.AreEqual(1500, numero);
        }

        #endregion

        #region Terceiro Cenário - Mais de dois símbolos em sequência.

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoIII()
        {
            int numero = _romano.Converte("III");

            Assert.AreEqual(3, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoXXII()
        {
            int numero = _romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoMDX()
        {
            int numero = _romano.Converte("MDX");

            Assert.AreEqual(1510, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoMDXV()
        {
            int numero = _romano.Converte("MDXV");

            Assert.AreEqual(1515, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoDCLXII()
        {
            int numero = _romano.Converte("DCLXII");

            Assert.AreEqual(662, numero);
        }

        #endregion

        #region Quarto Cenário - Símbolos em sequência e/ou invertidos.

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoIV()
        {
            int numero = _romano.Converte("IV");

            Assert.AreEqual(4, numero);
        }

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoXXIV()
        {
            int numero = _romano.Converte("XXIV");

            Assert.AreEqual(24, numero);
        }

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoDXLIIX()
        {
            int numero = _romano.Converte("DXLIIX");

            Assert.AreEqual(548, numero);
        }

        #endregion

        #region Quinto Cenário - Testes que devem falhar - Símbolos com sequência incorreta.

        [Test, Category("Falha")]
        public void DeveFalharComQuatroSimbolosIguaisIIII()
        {
            int numero = _romano.Converte("IIII");

            Assert.AreEqual(0, numero);
        }

        [Test, Category("Falha")]
        public void DeveFalharComQuatroSimbolosIguaisVVVV()
        {
            int numero = _romano.Converte("VVVV");

            Assert.AreEqual(0, numero);
        }

        #endregion
    }
}