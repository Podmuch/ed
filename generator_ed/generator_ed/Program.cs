using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator_ed
{
    public enum PoziomWyksztalcenia
    {
        Wyzsze,
        SrednieZawodowe,
        SrednieOgolnoksztalcace,
        ZasadniczeZawodowe,
        Gimnazjalne,
        Podstawowe,
        PodstawoweNieukonczone_BezWyksztalcenia
    }
    public enum PlecEnum
    {
        Kobieta,
        Mezczyzna
    }
    public enum ProgiWiekowe
    {
        do20lat,
        do30lat,
        do40lat,
        do50lat,
        do60lat,
        ponad60lat
    }
    public enum KierunekLubProfilWyksztalcenia
    {
        Pedagogiczne,
        Humanistyczne,
        Artystyczne,
        Spoleczne,
        Prawne,
        Medyczne,
        RolniczeLesneRybactwa,
        DziennikarstwoInformacja,
        MatematycznoStatystyczne,
        Informatyczne,
        OpiekaSpoleczna,
        ArchitekturaBudownictwo,
        UslugiDlaLudnosci,
        OchronaSrodowiska,
        UslugiTransportowe,
        OchronaBezpieczenstwo,
        EkonomiaAdministracja,
        Biologiczne,
        Fizyczne,
        InzynieryjnoTechniczne,
        ProdukcjaPrzetworstwo,
        SzkolaPodstawowa,
        Gimnazjum,
        SzkolaPonadgimnazjalna,
        SzkolaPolicealna,
        SzkolySpecjalne,
        SzkolaZawodowa,
        LiceumOgolnoksztalcace,
        LiceumProfilowane,
        Technikum,
        GastronomicznoHotelarskie,
        Samochodowe,
        Fryzjerskie,
        Odziezowe,
    }
    public enum RodzajMiejscowosci
    {
        wies,
        miastodo10tys,
        miastodo50tys,
        miastodo100tys,
        miastoponad100tys
    }
    public enum ProgiDochodu
    {
        do20tys,
        do30tys,
        do50tys,
        do100tys,
        ponad100tys
    }
    public enum PrzedzialyByciaBezrobotnym
    {
        do3miesiecy,
        do6miesiecy,
        do12miesiecy,
        ponad12miesiecy
    }

    public enum RodzajUczelni
    {
        Uniwersytet,
        WyzszaSzkolaTechniczna,
        WyzszaSzkolaEkonomiczna,
        WyzszaSzkolaMorska,
        UniwersytetMedyczny,
        AkademiaWychowaniaFizycznego,
        WyzszaSzkolaArtystyczna,
        PozostaleSzkolyWyzsze,
        LiceumOgolnoksztalcace,
        LiceumProfilowe,
        Gimnazjum,
        SzkolaPodstawowa,
        ZasadniczaSzkolaZawodowa,
    }
    public enum ProgiAbsolwentow
    {
        ponizej500,
        od500do1000,
        od1000do1500,
        od1500do2500,
        od2500do5000,
        powyzej5000
    }

    public enum TrojmiejskieUczelnie
    {
        UniwersytetGdanski,
        PolitechnikaGdanska,
        WyzszaSzkolaAdministracjiIBiznesu,
        SzkolaWyzszaPsychologiiSpolecznej,
        WyzszaSzkolaBankowa,
        WyzszaSzkolaKomunikacjiSpolecznej,
        SopockaSzkolaWyzsza,
        AkademiaWychowaniaFizycznegoiSportu,
        WyzszaSzkolaTurystykiiHotelarstwawGdansku,
        GdanskaWyzszaSzkolaHumanistyczna,
        AkademiaMarynarkiWojennej,
        AkademiaSztukPieknych,
        LiceumOgolnoksztalcace,
        LiceumProfilowe,
        Gimnazjum,
        SzkolaPodstawowa,
        ZasadniczaSzkolaZawodowa,
        Inna
    }
    
    public enum DziedzinaPracy
    {
        PracaNajemnaPozaRolnictwem,
        PracaNaWlasnyRachunekPozaRolnictwem,
        PracaWRolnictwie,
        Emerytura,
        Renta,
        PozostaleZrodla,
        Utrzymywani,
        Nieustalone 
    }
    public enum OkresBudowy
    {
        przed1918,
        pomiedzy1918a1944,
        pomiedzy1945a1970,
        pomiedzy1971a1978,
        pomiedzy1979a1988,
        pomiedzy1989a2002,
        po2003roku
    }
    public enum ProgiPowierzchniUzytkowej
    {
        poniżej7m2naOsobe,
        od7do10m2naOsobe,
        od10do15m2naOsobe,
        od15do20m2naOsobe,
        od20do30m2naOsobe,
        ponad30m2naOsobe
    }
    public enum SposobOgrzewaniaIZrodloEnergii
    {
        COzbiorowe,
        COindywidualne,
        piece,
    }
    public enum IloscOsobNaIzbe
    {
        ponizejpol,
        odpoldo1,
        od1do1ipol,
        od1ipoldo2,
        od2do3,
        ponad3
    }

    public enum IloscIzbWMieszkaniu
    {
        jednaizba,
        dwieizby,
        trzyizby,
        czteryizby,
        pieciwiecejizb
    }
    public enum RodzajeStanuCywilnego
    {
        kawalerowie_panny,
        żonaci_zamężne,
        wdowcy_wdowy,
        rozwiedzeni_rozwiedzione,
        nieustalony
    }
    public enum ProgiOsobNaUtrzymaniu
    {
        OsobaSamodzielna,
        RodzinaBezDzieci,
        JednoDziecko,
        DwojeDzieci,
        TrojeDzieci,
        CzworoIWiecejDzieci
    }
    public class Rekord
    {
        public bool Status_Bezrobotnego { get; set; }
        public PoziomWyksztalcenia Wyksztalcenie { get; set; }
        public ProgiWiekowe Wiek { get; set; }
        public PlecEnum Plec { get; set; }
        public KierunekLubProfilWyksztalcenia KierunekLubProfil { get; set; }
        public RodzajMiejscowosci Pochodzenie { get; set; }
        public ProgiOsobNaUtrzymaniu IloscOsobNaUtrzymaniu { get; set; }
        public ProgiDochodu DochodRodziny { get; set; }
        public PrzedzialyByciaBezrobotnym OkresByciaBezrobotnym { get; set; }
        public RodzajUczelni Uczelnia { get; set; }
        public ProgiAbsolwentow IloscAbsolwentow { get; set; }
        public TrojmiejskieUczelnie NazwaUczelni { get; set; }
        public DziedzinaPracy DziedzinaOstatniegoZatrudnienia { get; set; }
        public OkresBudowy OkresBudowyMieszkania { get; set; }
        public IloscOsobNaIzbe LiczbaOsobNaIzbe { get; set; }
        public ProgiPowierzchniUzytkowej PowierzchniaUzytkowa { get; set; }
        public IloscIzbWMieszkaniu LiczbaIzb { get; set; }
        public bool WodociagiIUstep { get; set; }
        public bool CzyJestLazienka { get; set; }
        public bool CieplaWoda { get; set; }
        public bool Gaz { get; set; }
        public bool Niepelnosprawnosc { get; set; }
        public RodzajeStanuCywilnego StanCywilny { get; set; }
        public SposobOgrzewaniaIZrodloEnergii OgrzewanieIEnergia { get; set; }
        public Rekord(bool _statusbezrobotnego, PoziomWyksztalcenia _wyksztalcenie, ProgiWiekowe _wiek, PlecEnum _plec, KierunekLubProfilWyksztalcenia _kierunek, RodzajMiejscowosci _pochodzenie,
                      ProgiOsobNaUtrzymaniu _osobynautrzymaniu, ProgiDochodu _dochod, PrzedzialyByciaBezrobotnym _czasbyciabezrobotnym, RodzajUczelni _uczelnia, ProgiAbsolwentow _iloscabsolwentow,
                      TrojmiejskieUczelnie _nazwauczelni, DziedzinaPracy _ostatniezatrudnienie, OkresBudowy _okresbudowymieszkania, IloscOsobNaIzbe _osobynaizbe, ProgiPowierzchniUzytkowej _powierzchniauzytkowa,
                      IloscIzbWMieszkaniu _iloscizb, bool _wodociagi, bool _lazienka, bool _cieplawoda, bool _gaz, bool _niepelnosprawnosc, RodzajeStanuCywilnego _stancywilny, SposobOgrzewaniaIZrodloEnergii _ogrzewanie) 
        {
            Status_Bezrobotnego = _statusbezrobotnego;
            Wyksztalcenie = _wyksztalcenie;
            Wiek = _wiek;
            Plec = _plec;
            KierunekLubProfil = _kierunek;
            Pochodzenie = _pochodzenie;
            IloscOsobNaUtrzymaniu = _osobynautrzymaniu;
            DochodRodziny = _dochod;
            OkresByciaBezrobotnym = _czasbyciabezrobotnym;
            Uczelnia = _uczelnia;
            IloscAbsolwentow = _iloscabsolwentow;
            NazwaUczelni = _nazwauczelni;
            DziedzinaOstatniegoZatrudnienia = _ostatniezatrudnienie;
            LiczbaOsobNaIzbe = _osobynaizbe;
            PowierzchniaUzytkowa = _powierzchniauzytkowa;
            LiczbaIzb = _iloscizb;
            WodociagiIUstep = _wodociagi;
            CzyJestLazienka = _lazienka;
            CieplaWoda = _cieplawoda;
            Gaz = _gaz;
            Niepelnosprawnosc = _niepelnosprawnosc;
            StanCywilny = _stancywilny;
            OgrzewanieIEnergia = _ogrzewanie;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Status_Bezrobotnego ? "bezrobotny" : "pracujacy");
            builder.Append(",");
            builder.Append(Wyksztalcenie == PoziomWyksztalcenia.Gimnazjalne ? "Gimnazjalne" :
                           Wyksztalcenie == PoziomWyksztalcenia.Podstawowe ? "Podstawowe" :
                           Wyksztalcenie == PoziomWyksztalcenia.PodstawoweNieukonczone_BezWyksztalcenia ? "BrakWyksztalcenia" :
                           Wyksztalcenie == PoziomWyksztalcenia.SrednieOgolnoksztalcace ? "SrednieOgolnoksztalcace" :
                           Wyksztalcenie == PoziomWyksztalcenia.SrednieZawodowe ? "SrednieZawodowe" :
                           Wyksztalcenie == PoziomWyksztalcenia.Wyzsze ? "Wyzsze" : "ZasadniczeZawodowe");
            builder.Append(",");
            builder.Append(Wiek==ProgiWiekowe.do20lat?"do 20 lat":
                           Wiek==ProgiWiekowe.do30lat?"do 30 lat":
                           Wiek==ProgiWiekowe.do40lat?"do 40 lat":
                           Wiek==ProgiWiekowe.do50lat?"do 50 lat":
                           Wiek==ProgiWiekowe.do60lat?"do 60 lat":"ponad 60 lat");
            builder.Append(",");
            builder.Append(Plec == PlecEnum.Kobieta ? "Kobieta" : "Mezczyzna");
            builder.Append(",");
            builder.Append(KierunekLubProfil == KierunekLubProfilWyksztalcenia.ArchitekturaBudownictwo?"Architektura lub Budownictwo":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Artystyczne?"Artystyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Biologiczne?"Biologiczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.DziennikarstwoInformacja?"Dziennikarstwo i Informacja":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.EkonomiaAdministracja?"Ekonomia i Administracja":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Fizyczne?"Fizyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Fryzjerskie?"Fryzjerskie":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.GastronomicznoHotelarskie?"Gastronomiczno-Hotelarskie":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Gimnazjum?"Gimnazjum":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Humanistyczne?"Humanistyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Informatyczne?"Informatyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.InzynieryjnoTechniczne?"Inzynieryjno-Techniczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.LiceumOgolnoksztalcace?"Liceum Ogolnoksztalcace":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.LiceumProfilowane?"Liceum Profilowane":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.MatematycznoStatystyczne?"Matematyczno-Statystyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Medyczne?"Medyczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.OchronaBezpieczenstwo?"Ochrona i Bezpieczenstwo":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.OchronaSrodowiska?"Ochrona Srodowiska":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Odziezowe?"Odziezowe":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.OpiekaSpoleczna?"Opieka Spoleczna":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Pedagogiczne?"Pedagogiczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Prawne?"Prawne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.ProdukcjaPrzetworstwo?"Produkcja i Przetworstwo":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.RolniczeLesneRybactwa?"Rolnicze Lesne lub Rybactwo":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Samochodowe?"Samochodowe":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Spoleczne?"Spoleczne":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.SzkolaPodstawowa?"Szkola Podstawowa":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.SzkolaPolicealna?"Szkola Policealna":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.SzkolaPonadgimnazjalna?"Szkola Ponadgimnazjalna":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.SzkolaZawodowa?"Szkola Zawodowa":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.Technikum?"Technikum":
                           KierunekLubProfil == KierunekLubProfilWyksztalcenia.UslugiDlaLudnosci?"Uslugi dla Ludnosci":"Uslugi Transportowe");
            builder.Append(",");
            builder.Append(Pochodzenie == RodzajMiejscowosci.wies ? "Wies" :
                           Pochodzenie == RodzajMiejscowosci.miastodo10tys ? "Miasto do 10 tys" :
                           Pochodzenie == RodzajMiejscowosci.miastodo50tys ? "Miasto do 50 tys" :
                           Pochodzenie == RodzajMiejscowosci.miastodo100tys ? "Miasto do 100 tys" : "Miasto ponad 100 tys");
            builder.Append(",");
            builder.Append(IloscOsobNaUtrzymaniu == ProgiOsobNaUtrzymaniu.OsobaSamodzielna ? "osoba samodzielna" :
                           IloscOsobNaUtrzymaniu == ProgiOsobNaUtrzymaniu.RodzinaBezDzieci ? "rodzina bez dzieci" :
                           IloscOsobNaUtrzymaniu == ProgiOsobNaUtrzymaniu.JednoDziecko ? "jedno dziecko" :
                           IloscOsobNaUtrzymaniu == ProgiOsobNaUtrzymaniu.DwojeDzieci ? "dwoje dzieci" :
                           IloscOsobNaUtrzymaniu == ProgiOsobNaUtrzymaniu.TrojeDzieci ? "troje dzieci" : "czworo i więcej dzieci");
            builder.Append(",");
            builder.Append(DochodRodziny == ProgiDochodu.do20tys ? "do 20 tys" :
                           DochodRodziny == ProgiDochodu.do30tys ? "do 30 tys" :
                           DochodRodziny == ProgiDochodu.do50tys ? "do 50 tys" :
                           DochodRodziny == ProgiDochodu.do100tys ? "do 100 tys" : "powyzej 100 tys");
            builder.Append(",");
            builder.Append(OkresByciaBezrobotnym == PrzedzialyByciaBezrobotnym.do3miesiecy ? "do 3 miesiecy" :
                           OkresByciaBezrobotnym == PrzedzialyByciaBezrobotnym.do6miesiecy ? "do 6 miesiecy" :
                           OkresByciaBezrobotnym == PrzedzialyByciaBezrobotnym.do12miesiecy ? "do 12 miesiecy" : "ponad 12 miesiecy");
            builder.Append(",");
            builder.Append(Uczelnia == RodzajUczelni.Uniwersytet ? "Uniwersytet" :
                           Uczelnia == RodzajUczelni.UniwersytetMedyczny ? "Uniwersytet Medyczny" :
                           Uczelnia == RodzajUczelni.AkademiaWychowaniaFizycznego ? "Akademia Wychowania Fizycznego" :
                           Uczelnia == RodzajUczelni.WyzszaSzkolaArtystyczna ? "Wyzsza Szkola Artystyczna" :
                           Uczelnia == RodzajUczelni.WyzszaSzkolaEkonomiczna ? "Wyzsza Szkola Ekonomiczna" :
                           Uczelnia == RodzajUczelni.WyzszaSzkolaMorska ? "Wyzsza Szkola Morska" :
                           Uczelnia == RodzajUczelni.WyzszaSzkolaTechniczna ? "Wyzsza Szkola Techniczna" :
                           Uczelnia == RodzajUczelni.PozostaleSzkolyWyzsze ? "Pozostale Szkoly Wyzsze" :
                           Uczelnia == RodzajUczelni.Gimnazjum ? "Gimnazjum" :
                           Uczelnia == RodzajUczelni.LiceumOgolnoksztalcace ? "Liceum Ogolnoksztalcace" :
                           Uczelnia == RodzajUczelni.LiceumProfilowe ? "Liceum Profilowe" :
                           Uczelnia == RodzajUczelni.SzkolaPodstawowa ? "Szkola Podstawowa" : "Zasadnicza Szkola Zawodowa");
            builder.Append(",");
            builder.Append(IloscAbsolwentow == ProgiAbsolwentow.od1000do1500 ? "1000-1500" :
                           IloscAbsolwentow == ProgiAbsolwentow.od1500do2500 ? "1500-2500" :
                           IloscAbsolwentow == ProgiAbsolwentow.od2500do5000 ? "2500-5000" :
                           IloscAbsolwentow == ProgiAbsolwentow.powyzej5000 ? "ponad 5000" :
                           IloscAbsolwentow == ProgiAbsolwentow.od500do1000 ? "500-1000" : "Ponizej 500");
            builder.Append(",");
            builder.Append(NazwaUczelni == TrojmiejskieUczelnie.AkademiaMarynarkiWojennej ? "Akademia Marynarki Wojennej" :
                           NazwaUczelni == TrojmiejskieUczelnie.AkademiaSztukPieknych ? "Akademia Sztuk Pieknych" :
                           NazwaUczelni == TrojmiejskieUczelnie.AkademiaWychowaniaFizycznegoiSportu ? "Akademia Wychowania Fizycznego i Sportu" :
                           NazwaUczelni == TrojmiejskieUczelnie.GdanskaWyzszaSzkolaHumanistyczna ? "Gdanska Wyzsza Szkola Humanistyczna" :
                           NazwaUczelni == TrojmiejskieUczelnie.Gimnazjum ? "Gimnazjum" :
                           NazwaUczelni == TrojmiejskieUczelnie.Inna ? "Inna Szkola" :
                           NazwaUczelni == TrojmiejskieUczelnie.LiceumOgolnoksztalcace ? "Liceum Ogolnoksztalcace" :
                           NazwaUczelni == TrojmiejskieUczelnie.LiceumProfilowe ? "Liceum Profilowe" :
                           NazwaUczelni == TrojmiejskieUczelnie.PolitechnikaGdanska ? "Politechnika Gdanska" :
                           NazwaUczelni == TrojmiejskieUczelnie.SopockaSzkolaWyzsza ? "Sopocka Szkola Wyzsza" :
                           NazwaUczelni == TrojmiejskieUczelnie.SzkolaPodstawowa ? "Szkola Podstawowa" :
                           NazwaUczelni == TrojmiejskieUczelnie.SzkolaWyzszaPsychologiiSpolecznej ? "Szkola Wyzsza Psychologii Spolecznej" :
                           NazwaUczelni == TrojmiejskieUczelnie.UniwersytetGdanski ? "Uniwersytet Gdanski" :
                           NazwaUczelni == TrojmiejskieUczelnie.WyzszaSzkolaAdministracjiIBiznesu ? "Wyzsza Szkola Administracji i Biznesu" :
                           NazwaUczelni == TrojmiejskieUczelnie.WyzszaSzkolaBankowa ? "Wyzsza Szkola Bankowa" :
                           NazwaUczelni == TrojmiejskieUczelnie.WyzszaSzkolaKomunikacjiSpolecznej ? "Wyzsza Szkola Komunikacji Spolecznej" :
                           NazwaUczelni == TrojmiejskieUczelnie.WyzszaSzkolaTurystykiiHotelarstwawGdansku ? "Wyzsza Szkola Turystyki i Hotelarstwa w Gdansku" : "Zasadnicza Szkola Zawodowa");
            builder.Append(",");
            builder.Append(DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.Emerytura ? "emerytura" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.Nieustalone ? "nie ustalone" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.Renta ? "renta" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.PozostaleZrodla ? "pozostale zrodla" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.PracaNajemnaPozaRolnictwem ? "praca najemna po za rolnictwem" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.PracaNaWlasnyRachunekPozaRolnictwem ? "praca na wlasny rachunek po za rolnictwem" :
                           DziedzinaOstatniegoZatrudnienia == DziedzinaPracy.PracaWRolnictwie ? "praca w rolnictwie" : "utrzymywani");
            builder.Append(",");
            builder.Append(OkresBudowyMieszkania == OkresBudowy.przed1918 ? "przed 1918" :
                           OkresBudowyMieszkania == OkresBudowy.pomiedzy1918a1944 ? "pomiedzy 1918 a 1944" :
                           OkresBudowyMieszkania == OkresBudowy.pomiedzy1945a1970 ? "pomiedzy 1945 a 1970" :
                           OkresBudowyMieszkania == OkresBudowy.pomiedzy1971a1978 ? "pomiedzy 1971 a 1978" :
                           OkresBudowyMieszkania == OkresBudowy.pomiedzy1979a1988 ? "pomiedzy 1979 a 1988" :
                           OkresBudowyMieszkania == OkresBudowy.pomiedzy1989a2002 ? "pomiedzy 1989 a 2002" : "po 2003 roku");
            builder.Append(",");
            builder.Append(LiczbaOsobNaIzbe == IloscOsobNaIzbe.ponizejpol ? "ponizej 0.5" :
                           LiczbaOsobNaIzbe == IloscOsobNaIzbe.odpoldo1 ? "od 0.5 do 1" :
                           LiczbaOsobNaIzbe == IloscOsobNaIzbe.od1do1ipol ? "od 1 do 1.5" :
                           LiczbaOsobNaIzbe == IloscOsobNaIzbe.od1ipoldo2 ? "od 1.5 do 2" :
                           LiczbaOsobNaIzbe == IloscOsobNaIzbe.od2do3 ? "od 2 do 3" :"ponad 3");
            builder.Append(",");
            builder.Append(PowierzchniaUzytkowa == ProgiPowierzchniUzytkowej.poniżej7m2naOsobe ? "ponizej 7 m2" :
                           PowierzchniaUzytkowa == ProgiPowierzchniUzytkowej.od7do10m2naOsobe ? "od 7 do 10 m2" :
                           PowierzchniaUzytkowa == ProgiPowierzchniUzytkowej.od10do15m2naOsobe ? "od 10 do 15 m2" :
                           PowierzchniaUzytkowa == ProgiPowierzchniUzytkowej.od15do20m2naOsobe ? "od 15 do 20 m2" :
                           PowierzchniaUzytkowa == ProgiPowierzchniUzytkowej.od20do30m2naOsobe ? "od 20 do 30 m2" :"ponad 30 m2");
            builder.Append(",");
            builder.Append(LiczbaIzb == IloscIzbWMieszkaniu.jednaizba? "jedna" :
                           LiczbaIzb == IloscIzbWMieszkaniu.dwieizby ? "dwie" :
                           LiczbaIzb == IloscIzbWMieszkaniu.trzyizby ? "trzy" :
                           LiczbaIzb == IloscIzbWMieszkaniu.czteryizby ? "cztery" :"piec i wiecej");
            builder.Append(",");
            builder.Append(WodociagiIUstep? "dostepne" :"brak");
            builder.Append(",");
            builder.Append(CzyJestLazienka? "jest":"brak"); 
            builder.Append(",");
            builder.Append(CieplaWoda? "jest":"brak");
            builder.Append(",");
            builder.Append(Gaz?"dostepny":"brak");
            builder.Append(",");
            builder.Append(Niepelnosprawnosc?"niepelnosprawny":"zdrowy");  
            builder.Append(",");
            builder.Append(StanCywilny == RodzajeStanuCywilnego.nieustalony? "nieustalony" :
                           StanCywilny == RodzajeStanuCywilnego.kawalerowie_panny ? "kawaler lub panna" :
                           StanCywilny == RodzajeStanuCywilnego.żonaci_zamężne ? "zonaty lub zamezna" :
                           StanCywilny == RodzajeStanuCywilnego.wdowcy_wdowy ? "wdowiec lub wdowa" :"rozwiedzony lub rozwiedzona"); 
            builder.Append(",");
            builder.Append(OgrzewanieIEnergia == SposobOgrzewaniaIZrodloEnergii.COindywidualne ? "CO indywidualne" :
                           OgrzewanieIEnergia == SposobOgrzewaniaIZrodloEnergii.COzbiorowe ? "CO zbiorowe" : "piec");
            builder.Append("\n");
            return builder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder lines = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < 750000;i++)
            {
                Rekord osoba = new Rekord(rand.Next(0, 100) > 85, (PoziomWyksztalcenia)rand.Next(0, Enum.GetNames(typeof(PoziomWyksztalcenia)).Length), (ProgiWiekowe)rand.Next(0, Enum.GetNames(typeof(ProgiWiekowe)).Length),
                                          (PlecEnum)rand.Next(0, Enum.GetNames(typeof(PlecEnum)).Length), (KierunekLubProfilWyksztalcenia)rand.Next(0, Enum.GetNames(typeof(KierunekLubProfilWyksztalcenia)).Length), (RodzajMiejscowosci)rand.Next(0, Enum.GetNames(typeof(RodzajMiejscowosci)).Length),
                                          (ProgiOsobNaUtrzymaniu)rand.Next(0, Enum.GetNames(typeof(ProgiOsobNaUtrzymaniu)).Length), (ProgiDochodu)rand.Next(0, Enum.GetNames(typeof(ProgiDochodu)).Length), (PrzedzialyByciaBezrobotnym)rand.Next(0, Enum.GetNames(typeof(PrzedzialyByciaBezrobotnym)).Length),
                                          (RodzajUczelni)rand.Next(0, Enum.GetNames(typeof(RodzajUczelni)).Length), (ProgiAbsolwentow)rand.Next(0, Enum.GetNames(typeof(ProgiAbsolwentow)).Length), (TrojmiejskieUczelnie)rand.Next(0, Enum.GetNames(typeof(TrojmiejskieUczelnie)).Length),
                                          (DziedzinaPracy)rand.Next(0, Enum.GetNames(typeof(DziedzinaPracy)).Length), (OkresBudowy)rand.Next(0, Enum.GetNames(typeof(OkresBudowy)).Length), (IloscOsobNaIzbe)rand.Next(0, Enum.GetNames(typeof(IloscOsobNaIzbe)).Length),
                                          (ProgiPowierzchniUzytkowej)rand.Next(0, Enum.GetNames(typeof(ProgiPowierzchniUzytkowej)).Length), (IloscIzbWMieszkaniu)rand.Next(0, Enum.GetNames(typeof(IloscIzbWMieszkaniu)).Length), rand.Next(0, 100) < 98,
                                          rand.Next(0, 100) < 98, rand.Next(0, 100) < 98, rand.Next(0, 100) < 98, rand.Next(0, 100) >75, (RodzajeStanuCywilnego)rand.Next(0,Enum.GetNames(typeof(RodzajeStanuCywilnego)).Length),
                                          (SposobOgrzewaniaIZrodloEnergii)rand.Next(0,Enum.GetNames(typeof(SposobOgrzewaniaIZrodloEnergii)).Length));
                lines.Append(osoba.ToString());
            }
            File.WriteAllText("Dane.csv", lines.ToString());
        }
    }
}
