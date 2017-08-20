using Common.Extensions;
using SQLite;
using System;

namespace Madplan.Models
{
    public class Food : BaseModel
    {
        #region private fields

        //private string _name;
        private double _quantity;
        private string _quantityType;
        //private double _energiKj;
        //private double _energiKcal;
        //private double _proteinTotal;
        //private double _kulhydratDifferens;
        //private double _kulhydratTilgaengelig;
        //private double _tilsatSukker;
        //private double _kostfiber;
        //private double _fedtTotal;
        private double _avitamin;
        private double _dvitamin;
        private double _evitamin;
        private double _k1vitamin;
        private double _b12vitamin;
        private double _cvitamin;
        private double _calcium;
        private double _magnesium;
        private double _jern;
        private double _zink;
        private double _selen;
        private double _sumMaettedeFedtsyrer;
        private double _cadmium;
        private double _sumMonoumaettedeFedtsyrer;
        private double _sumPolymaettedeFedtsyrer;
        private double _transFedtsyrer;
        private double _cholesterol;
        #endregion

        #region public properties

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int FoodId { get; set; }

        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }
        public double Quantity
        {
            get { return _quantity; }
            set { SetValue(ref _quantity, value); }
        }
        public string QuantityType
        {
            get { return _quantityType; }
            set { SetValue(ref _quantityType, value); }
        }

        public int QuantityConververId { get; set; }

        public double EnergiKj
        {
            get { return _energiKj; }
            set { SetValue(ref _energiKj, value); }
        }
        public double EnergiKcal
        {
            get { return _energiKcal; }
            set { SetValue(ref _energiKcal, value); }
        }
        public double ProteinTotal
        {
            get { return _proteinTotal; }
            set { SetValue(ref _proteinTotal, value); }
        }
        public double KulhydratDifferens
        {
            get { return _kulhydratDifferens; }
            set { SetValue(ref _kulhydratDifferens, value); }
        }
        public double KulhydratTilgaengelig
        {
            get { return _kulhydratTilgaengelig; }
            set { SetValue(ref _kulhydratTilgaengelig, value); }
        }
        public double TilsatSukker
        {
            get { return _tilsatSukker; }
            set { SetValue(ref _tilsatSukker, value); }
        }
        public double Kostfiber
        {
            get { return _kostfiber; }
            set { SetValue(ref _kostfiber, value); }
        }
        public double FedtTotal
        {
            get { return _fedtTotal; }
            set { SetValue(ref _fedtTotal, value); }
        }

        public bool QuantityVisible { get; set; }
        public bool BasicRecipe { get; set; }
        public bool ShoppingListChecked { get; set; }

        public double Avitamin
        {
            get { return _avitamin; }
            set { SetValue(ref _avitamin, value); }
        }
        public double Dvitamin
        {
            get { return _dvitamin; }
            set { SetValue(ref _dvitamin, value); }
        }
        public double Evitamin
        {
            get { return _evitamin; }
            set { SetValue(ref _evitamin, value); }
        }
        public double K1vitamin
        {
            get { return _k1vitamin; }
            set { SetValue(ref _k1vitamin, value); }
        }
        public double B12vitamin
        {
            get { return _b12vitamin; }
            set { SetValue(ref _b12vitamin, value); }
        }
        public double Cvitamin
        {
            get { return _cvitamin; }
            set { SetValue(ref _cvitamin, value); }
        }
        public double Calcium
        {
            get { return _calcium; }
            set { SetValue(ref _calcium, value); }
        }
        public double Magnesium
        {
            get { return _magnesium; }
            set { SetValue(ref _magnesium, value); }
        }
        public double Jern
        {
            get { return _jern; }
            set { SetValue(ref _jern, value); }
        }
        public double Zink
        {
            get { return _zink; }
            set { SetValue(ref _zink, value); }
        }
        public double Selen
        {
            get { return _selen; }
            set { SetValue(ref _selen, value); }
        }
        public double Cadmium
        {
            get { return _cadmium; }
            set { SetValue(ref _cadmium, value); }
        }
        public double SumMaettedeFedtsyrer
        {
            get { return _sumMaettedeFedtsyrer; }
            set { SetValue(ref _sumMaettedeFedtsyrer, value); }
        }
        public double SumMonoumaettedeFedtsyrer
        {
            get { return _sumMonoumaettedeFedtsyrer; }
            set { SetValue(ref _sumMonoumaettedeFedtsyrer, value); }
        }
        public double SumPolymaettedeFedtsyrer
        {
            get { return _sumPolymaettedeFedtsyrer; }
            set { SetValue(ref _sumPolymaettedeFedtsyrer, value); }
        }
        public double TransFedtsyrer
        {
            get { return _transFedtsyrer; }
            set { SetValue(ref _transFedtsyrer, value); }
        }
        public double Cholesterol
        {
            get { return _cholesterol; }
            set { SetValue(ref _cholesterol, value); }
        }

        public double Svind { get; set; }
        public double Ncf { get; set; } // Proteinomregningsfaktor(NCF)
        public double TotalN { get; set; }
        public double ProteinDeklaration { get; set; }
        public double KulhydratDeklaration { get; set; }
        public double FCF { get; set; } // Fedtsyrekonverteringsfaktor (FCF)
        public double Alkohol { get; set; }
        public double Aske { get; set; }
        public double Torstof { get; set; } // Tørstof
        public double Vand { get; set; }
        public double Retinol { get; set; }
        public double Bcaroten { get; set; }
        public double D3cholecalciferol { get; set; }
        public double Hydroxycholecalciferol { get; set; } // 25-hydroxycholecalciferol
        public double AlfaTokoferol { get; set; }
        public double GammaTokoferol { get; set; }
        public double DeltaTokoferol { get; set; }
        public double AlfaTokotrienol { get; set; }
        public double B1vitamin { get; set; }
        public double Thiamin { get; set; }
        public double HET { get; set; } // HET, hydroxyethylthiazole
        public double B2vitaminRiboflavin { get; set; }
        public double Niacin { get; set; }
        public double Niacin2 { get; set; }
        public double B6vitamin { get; set; }
        public double Pantothensyre { get; set; }
        public double Biotin { get; set; }
        public double Folat { get; set; }
        public double FritFolat { get; set; }
        public double Lascorbinsyre { get; set; } // L-ascorbinsyre
        public double Ldehydroascorbinsyre { get; set; } // L-dehydroascorbinsyre
        public double Chlorid { get; set; }
        public double Natrium { get; set; }
        public double Kalium { get; set; }
        public double Phosphor { get; set; }
        public double Kobber { get; set; }
        public double Jod { get; set; }
        public double Mangan { get; set; }
        public double Chrom { get; set; }
        public double Molybdbaen { get; set; } // Molybdæm
        public double Cobolt { get; set; }
        public double Nikkel { get; set; }
        public double kviksolv { get; set; } // Kviksølv
        public double Arsen { get; set; }
        public double Bly { get; set; }
        public double Tin { get; set; }
        public double Lmaelkesyre { get; set; } // L-mælkesyre
        public double Dmaelkesyre { get; set; } // D-mælkesyre
        public double MaelkesyreTotal { get; set; } // Mælkesyre, Total
        public double Citronsyre { get; set; }
        public double Oxalsyre { get; set; }
        public double Aeblesyre { get; set; } // Æblesyre
        public double Eddikesyre { get; set; }
        public double Benzoesyre { get; set; }
        public double OrganiskeSyrerTotal { get; set; }
        public double Histamin { get; set; }
        public double Tyramin { get; set; }
        public double Phenylethylamin { get; set; }
        public double Putrescin { get; set; }
        public double Cadaverin { get; set; }
        public double Spermin { get; set; }
        public double Spermidin { get; set; }
        public double Serotonin { get; set; }
        public double Fructose { get; set; }
        public double Galaktose { get; set; }
        public double Glycose { get; set; }
        public double MonosacchariderTotal { get; set; }
        public double Lactose { get; set; }
        public double Maltose { get; set; }
        public double Saccharose { get; set; }
        public double DisacchariderTotal { get; set; }
        public double Raffinose { get; set; }
        public double AndreSukkerarter { get; set; }
        public double SukkerarterIalt { get; set; }
        public double Sorbitol { get; set; }
        public double Mannitol { get; set; }
        public double Inositol { get; set; }
        public double Maltitol { get; set; }
        public double SukkerAlkoholerTotal { get; set; }
        public double Stivelse { get; set; }
        public double Hexoses { get; set; }
        public double Pentoses { get; set; }
        public double UronicAcids { get; set; }
        public double Cellulose { get; set; }
        public double Lignin { get; set; }
        public double CrudeFibre { get; set; }
        public double NDF { get; set; } // Neutr.Det.Fibre (NDF)
        public double C40 { get; set; } // C4:0 Smørsyre; Butansyre; Butanoic acid
        public double C60 { get; set; } // C6:0 Capronsyre; Hexansyre; Hexanoic acid
        public double C80 { get; set; } // C8:0 Caprylsyre; Octansyre; Octanoic acid
        public double C100 { get; set; } // C10:0 Caprinsyre; Decansyre; Decanoic acid
        public double C120 { get; set; } // C12:0 Laurinsyre; Dodecansyre; Dodecanoic acid
        public double C140 { get; set; } // C14:0 Myristinsyre; Tetradecansyre; Tetradecanoic acid
        public double C150 { get; set; } // C15:0 Pentadecansyre; Pentadecanoic acid
        public double C160 { get; set; } // C16:0 Palmitinsyre; Hexadecansyre; Hexadecanoic acid
        public double C170 { get; set; } // C17:0 Margarinsyre; Heptadecansyre; Heptadecanoic acid
        public double C180 { get; set; } // C18:0 Stearinsyre; Octadecansyre; Octadecanoic acid
        public double C200 { get; set; } // C20:0 Arachinsyre; Eicosansyre; Eicosanoic acid
        public double C220 { get; set; } // C22:0 Behensyre; Docosansyre; Docosanoic acid
        public double C240 { get; set; } // C24:0 Lignocerinsyre; Tetracosansyre; Tetracosanoic acid
        public double AndreMaettedeFedtsyrer { get; set; } // Andre mættede fedtsyrer
        public double C141n5 { get; set; } // C14:1,n-5 Myristoleinsyre; cis-9-Tetradecensyre; (Z)-Tetradec-9-enoic acid
        public double C151 { get; set; } // C15:1 Pentadecensyre; (Z)-Pentadec-10-enoic acid
        public double C161n7 { get; set; } // C16:1,n-7 Palmitoleinsyre; cis-9-Hexadecensyre; (Z)-Hexadec-9-enoic acid
        public double C161trans { get; set; } // C16:1,trans Palmitelaidinsyre; trans-Hexadecensyre; (E)-Hexadec-9-enoic acid
        public double C171n7 { get; set; } // C17:1,n-7 cis-10-Heptadecensyre; (Z)-Heptadec-10-enoic acid
        public double C181n9 { get; set; } // C18:1,n-9 Oliesyre; cis-9-Octadecensyre; (Z)-Octadec-9-enoic acid
        public double C181n7 { get; set; } // C18:1,n-7 cis-Vaccensyre; cis-11-Octacecansyre; (Z)-Octadec-11-enoic acid
        public double C181trans { get; set; } // C18:1,t n-9 Elaidinsyre; trans 9-Octadecensyre; (E)-octadec-9-enoic acid
        public double C201n9 { get; set; } // C20:1,n-9 Gondoinsyre; cis-11-Eicosensyre; (11Z)-Eicosenoic acid; 
        public double C201n11 { get; set; } // C20:1,n-11 Gadoleinsyre; cis-9-Eicosensyre; cis-9-Eicosenoic acid; (9Z)-9-Eicosenoic acid
        public double C201trans { get; set; } // C20:1,trans trans-11-Eicosensyre; trans-11-Eicosenoic acid
        public double C221n9 { get; set; } // C22:1,n-9 Erukasyre; cis-13-docosensyre, (Z)-docos-13-enoic acid
        public double C221n11 { get; set; } // C22:1,n-11 Cetoleinsyre; cis-11-docosensyre; (11Z)-11-Docosenoic acid
        public double C221trans { get; set; } // C22:1,n-9,trans Brassidic; acid trans-13-docosensyre; (E)-13-Docosenoic acid
        public double C241n9 { get; set; } // C24:1,n-9 Nervonsyre; cis-15-tetracosensyre; (Z)-Tetracos-15-enoic acid
        public double AndreMonoumaettedeFedtsyrer { get; set; } // Andre monoumættede fedtsyrer
        public double C182n6 { get; set; } // C18:2,n-6 Linolsyre; cis-9,12-octadecadiensyre; (9Z,12Z)-9,12-octadecadienoic acid; 
        public double C182conjA { get; set; } // C18:2,conj-A Conjugeret Linolsyre (CLA), udifferentieret; Conjugated linoleic acids (CLA); 9,t11-CLA (1)
        public double C182trans { get; set; } // C18:2,trans trans-Linolsyre udifferentieret; 
        public double C183n3 { get; set; } // C18:3,n-3 α-Linolensyre; cis 9,12,15-octadecatriensyre; (9Z,12Z,15Z)-9,12,15-octadecatrienoic acid
        public double C183n6 { get; set; } // C18:3,n-6 γ-Linolensyre; cis 6,9,12-octadecatriensyre; 6Z,9Z,12Z-octadecatrienoic acid
        public double C184n3 { get; set; } // C18:4,n-3 Steridonsyre; cis-6,9,12,15-octadecatetraensyre; (6Z,9Z,12Z,15Z)-6,9,12,15-octadecatetraenoic acid
        public double C202n6 { get; set; } // C20:2,n-6 cis-11,14-eicosadiensyre; 11Z,14Z-eicosadienoic acid
        public double C204n3 { get; set; } // C20:4,n-3 n-3 Arachidonic acid 8Z,11Z,14Z,17Z-Eicosatetraenoic Acid
        public double C203n3 { get; set; } // C20:3,n-3 Eicosatrienoic acid ETE; all-cis-11,14,17-eicosatrienoic acid; 11Z,14Z,17Z-eicosatrienoic acid
        public double C203n6 { get; set; } // C20:3,n-6 Dihomo-γ-linolensyre DGLA; cis-8,11,14-eicosatrienoic acid; 8Z,11Z,14Z-eicosatrienoic acid
        public double C204n6 { get; set; } // C20:4,n-6 arachidonsyre; cis 5,8,11,14-eicosatetraensyre; (5Z,8Z,11Z,14Z)-5,8,11,14-Eicosatetraenoic acid
        public double C205n3 { get; set; } // C20:5,n-3 timnodonsyre, EPA cis 5,8,11,14,17-eicosapentaensyre; (5Z,8Z,11Z,14Z,17Z)-Eicosapentaenoic acid
        public double C225n3 { get; set; } // C22:5,n-3 clupanodonsyre DPA cis 7,10,13,16,19-docosapentaensyre; (7Z,10Z,13Z,16Z,19Z)-7,10,13,16,19-Docosapentaenoic acid
        public double C226n3 { get; set; } // C22:6,n-3 cervonic acid DHA cis 4,7,10,13,16,19-docosahexaensyre
        public double AndrePolymaettedeFedtsyrer { get; set; } // Andre Polymættede Fedtsyrer
        public double AndreFedtsyrer { get; set; }
        public double FedtsyrerTotal { get; set; }
        public double Sumn3Fedtsyrer { get; set; } // Sum n-3 fedtsyrer
        public double Sumn6Fedtsyrer { get; set; }
        public double Isoleucin { get; set; }
        public double Leucin { get; set; }
        public double Lusin { get; set; }
        public double Methionin { get; set; }
        public double Cystin { get; set; }
        public double Phenylalanin { get; set; }
        public double Tyrosin { get; set; }
        public double Threonin { get; set; }
        public double Tryptofan { get; set; }
        public double Valin { get; set; }
        public double Arginin { get; set; }
        public double Histidin { get; set; }
        public double Alanin { get; set; }
        public double Asparaginsyre { get; set; }
        public double Glutaminsyre { get; set; }
        public double Glucin { get; set; }
        public double Prolin { get; set; }
        public double Serin { get; set; }
        #endregion

        public Food()
        {
            QuantityType = Madplan.Models.QuantityType.gram;
            QuantityVisible = true;
            BasicRecipe = false;
            ShoppingListChecked = false;

            // Lav en ny QuantityConverter til denne madvare
            if (DataModel.Current.ListOfQuantityConverters == null)
                throw new ArgumentNullException("ListOfQuantityConverters er null, imens construkter af Food køres");

            QuantityConververId = DataModel.Current.GetNewQuantityConverterId();
        }
    }
}
