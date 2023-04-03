using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Camisas : Prenda
    {
        public bool mangaCorta = false;
        public bool cuelloMao = false;

        public int camisasMangaCortaMaoPremium = 100;
        public int camisasMangaCortaMao = 100;
        public int camisasMangaCortaPremium = 150;
        public int camisasMangaCorta = 150;
        public int camisasMangaCortaTotales;

        public int camisasMangaLargaMaoPremium = 75;
        public int camisasMangaLargaMao = 75;
        public int camisasMangaLargaPremium = 175;
        public int camisasMangaLarga = 175;
        public int camisasMangaLargaTotales;

        public Camisas()
        {
            camisasMangaCortaTotales = camisasMangaCorta + camisasMangaCortaMao + camisasMangaCortaMaoPremium + camisasMangaCortaPremium;
            camisasMangaLargaTotales = camisasMangaLarga + camisasMangaLargaMao + camisasMangaLargaMaoPremium + camisasMangaLargaPremium;
            StockTotal = camisasMangaCortaTotales + camisasMangaLargaTotales;
        }
    }
}
