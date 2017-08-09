using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class FoodDb
    {
        //Fødevaredata 2016	Column1 Svind   Energi, kJ Energi, kcal    Proteinomregningsfaktor(NCF)    total-N Protein, total  Protein, deklaration Kulhydrat best.v/diff.Kulhydrat, tilgængelig kulhydrat, deklaration  Tilsat sukker   Kostfibre Fedt, total Fedtsyrekonverteringsfaktor(FCF)   Alkohol Aske    Tørstof Vand    A-vitamin Retinol ß-caroten D-vitamin D3 cholecalciferol	25-hydroxycholecalciferol E-vitamin alfa-tokoferol gamma-tokoferol delta-tokoferol alfa-tokotrienol K1-vitamin B1-vitamin thiamin HET, hydroxyethylthiazole B2-vitamin, riboflavin Niacin  niacin2 B6-vitamin Pantothensyre   Biotin Folat   Frit folat  B12-vitamin C-vitamin L-ascorbinsyre L-dehydroascorbinsyre Chlorid, Cl Natrium, Na Kalium, K   Calcium, Ca Magnesium, Mg   Phosphor, P Jern, Fe    Kobber, Cu Zink, Zn    Jod, I Mangan, Mn  Chrom, Cr Selen, Se   Molybdæn, Mo Cobolt, Co  Nikkel, Ni Kviksølv, Hg    Arsen, As Cadmium, Cd Bly, Pb Tin, Sn L-mælkesyre D-mælkesyre Mælkesyre, total    Citronsyre Oxalsyre    Æblesyre Eddikesyre  Benzoesyre Organiske syrer, tot.Histamin Tyramin Phenylethylamin Putrescin   Cadaverin Spermin Spermidin Serotonin   Fructose Galaktose   Glucose Monosaccharider, total  Lactose Maltose Saccharose Disaccharider, total    Raffinose Andre sukkerarter Sukkerarter, ialt   Sorbitol Mannitol    Inositol Maltitol    Sukkeralkoholer, total Stivelse(a)Hexoses(b)Pentoses(c)UronicAcids Cellulose   Lignin Crude fibre Neutr.Det.Fibre(NDF)   C4:0	C6:0	C8:0	C10:0	C12:0	C14:0	C15:0	C16:0	C17:0	C18:0	C20:0	C22:0	C24:0	Andre mætt.C14:1, n-5	C15:1	C16:1, n-7	C16:1, trans C17:1, n-7	C18:1, n-9	C18:1, n-7	C18:1, trans n-9	C20:1, n-9	C20:1, n-11	C20:1, trans C22:1, n-9	C22:1, n-11	C22:1, trans C24:1, n-9	Andre monoumætt.	C18:2, n-6	C18:2, conj-A, udifferentieret C18:2, trans, udifferentieret C18:3, n-3	C18:3, n-6	C18:4, n-3	C20:2, n-6	C20:4, n-3	C20:3, n-3	C20:3, n-6	C20:4, n-6	C20:5, n-3	C22:5, n-3	C22:6, n-3	Andre polyumættede  Andre fedtsyrer Sum mættede Sum monoumættede    Sum polyumættede    Fedtsyrer, total Sum n-3 fedtsyrer Sum n-6 fedtsyrer Transfedtsyrer, total Cholesterol Isoleucin Leucin  Lysin Methionin   Cystin Phenylalanin    Tyrosin Threonin    Tryptofan Valin   Arginin Histidin    Alanin Asparaginsyre   Glutaminsyre Glycin  Prolin Serin

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

    }
}
