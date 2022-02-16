using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAYIT : MonoBehaviour
{
    static string ANAHTAR_REKOR_MAYIN_SAYISI = "RekorSureMayin";
    const string ANAHTAR_SECILI_MAYIN_SAYISI = "Selici Mayin Sayisi";

    const string KY_BUTTON_ANA_MENU_OYNA = "btnOyna";
    const string KY_BUTTON_ANA_MENU_AYARLAR = "btnAyarlar";
    const string KY_BUTTON_ANA_MENU_CIKIS = "btnCIKIS";

    const string KY_DIL = "dil";
    const string KY_SES = "ses";

    const string KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI = "txtUyariKutusu";
    const string KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA = "btnUyariKutusuBasla";
    const string KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL = "btnUyariKutusuIptal";
    const string KY_BOLUMLAR = "KY_BOLUMLAR";

    const string KY_TEXT_AYARLAR = "txtAyarlar";
    const string KY_TEXT_AYARLAR_SES = "txtAyarlarSes";
    const string KY_TEXT_AYARLAR_DIL = "txtAyarlarDil";
    const string KY_TEXT_AYARLAR_REKORLARI_SIFIRLA = "txtAyarlarRekorlariSifirla";
    const string KY_BUTTON_AYARLAR_SIFIRLA = "btnAyarlariSifirla";
    const string KY_BUTTON_AYARLAR_HAKKIMIZDA = "btnAyarlariHakkimizda";
    const string KY_BUTTON_AYARLAR_ANA_MENU = "btnAyarlariAnaMenu";

    const string KY_BUTTON_OYUN_BASLA = "btnOyunBasla";
    const string KY_TEXT_OYUN_REKOR = "txtOyunRekor";
    const string KY_TEXT_OYUN_OYUN_SONU_KAZANDIN = "txtOyunOyunSonuKazandin";
    const string KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN = "txtOyunOyunSonuKaybettin";
    const string KY_TEXT_OYUN_OYUN_SONU_MAYIN = "txtOyunOyunSonuMayin";
    const string KY_TEXT_OYUN_OYUN_SONU_SURE = "txtOyunOyunSonuSure";
    const string KY_TEXT_OYUN_OYUN_SONU_HAMLE = "txtOyunOyunSonuHamle";
    const string KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR= "txtOyunOyunSonuKazandinRekor";
    const string KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL= "txtOyunOyunSonuKazandinNormal";
    const string KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ = "txtOyunOyunSonuKaybettinMesaj";












    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void SetDil(string hangiDil)
    {
        PlayerPrefs.SetString(KY_DIL, hangiDil);

        switch (hangiDil)
        {
            case "tr":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "OYNA");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "AYARLAR");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "ÇIKIŞ");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "MAYIN");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "BAŞLA");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "İPTAL");
                PlayerPrefs.SetString(KY_BOLUMLAR, "BÖLÜMLER");

                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "AYARLAR");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "SES");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "DİL");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "BÜTÜN AYARLARI VE REKORLARI SIFIRLA");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "SIFIRLA");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "HAKKINDA");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "ANA MENÜ");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "BAŞLA");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "REKOR: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "KAZANDIN!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "KAYBETTİN!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "MAYIN");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "SÜRE");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "HAMLE");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "EN İYİ ZAMANNN!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "HİÇ FENA DEĞİL!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "TEKRAR DENE!");
                break;
            case "ru":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "Начать");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "Настройки");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "Выход");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "Мина");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "Начать");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "Отмена");
                PlayerPrefs.SetString(KY_BOLUMLAR, "РАЗДЕЛЫ");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "Настройки");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "Звук");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "Язык");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "Обнулить все настройки и рекорды");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "Обнулить");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "О Нас");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "Главное Меню");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "Начать");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "Рекорд: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "Выиграл!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "Проиграл!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "Мина");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "Время");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "Ход");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "Время Рекорда!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "Довольна Таки Неплохо!!!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "Пробуй, Ещё Лучшую!");

                break;

            case "es":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "Jugar");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "Ajustes");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "Salida");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "Mina");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "Empezar");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "Cancelación");
                PlayerPrefs.SetString(KY_BOLUMLAR, "SECCIONES");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "Ajustes");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "Sonido");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "Idioma");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "Restablecer todos los ajustes y récords ");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "Restablecer");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "Sobre Nosotros ");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "Menú Principal ");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "Empezar");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "Comenzar Récord: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, " ¡¡Has Ganado!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, " ¡Has Perdido! ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "Mina");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "Hora");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "Turno");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "Tiempo De Récord!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "¡¡¡Bastante bien!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "Inténtalo De Nuevo!");

                break;

            case "fr":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "Jouer");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "Réglages");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "Sortir");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "Mine");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "Démarrer");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "Annuler");
                PlayerPrefs.SetString(KY_BOLUMLAR, "SECTIONS");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "Paramètres");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "Son");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "Langue");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "Mettre à Zéro Tous Les Paramètres et Enregistrements");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "Remettre à Zéro");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "À Propos De Nous");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "Menu Principal");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "Démarrer");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "Top Score: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "Gagné !!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "Perdu !");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "Mine");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "Il Est Temps");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "Déplacement");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "Un Temps Du Record!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "C'est Plutôt Bien !");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "Essayez Encore!");



                break;

            case "jp":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "プレイする");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "設定");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "エクジット");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "地雷");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "始める");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "キャンセル");
                PlayerPrefs.SetString(KY_BOLUMLAR, "セクション");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "設定");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "音");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "言語");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "全ての設定と記録をリセット");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "リセット");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "私たちについて");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "メインメニュー");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "始める");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "記録: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "勝った！！！");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "負けちゃった！");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "地雷");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "時間");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "順番");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "記録時間!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "かなり良かった！");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "もう一回やってみましょう!");
                break;

            case "de":
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "Spielen");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "Einstellung");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "Beenden");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "Mine");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "Starten");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "Stornieren");
                PlayerPrefs.SetString(KY_BOLUMLAR, "ABSCHNITTE");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "Einstellungen");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "Töne");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "Sprache");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "Alle Einstellungen und Rekorde Zurücksetzen");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "Zurücksetzen");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "Über Uns");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "Hauptmenü");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "Starten");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "Rekord: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "Gewonnen!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "Verloren!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "Mine");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "Zeit");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "Gang");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "Rekordzeit!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "Nicht schlecht!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "Versuch nochmal!");
                break;


            default:
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_OYNA, "Play");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_AYARLAR, "Options");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_CIKIS, "Exit");

                PlayerPrefs.SetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI, "Mines");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA, "Start");
                PlayerPrefs.SetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL, "Cancel");
                PlayerPrefs.SetString(KY_BOLUMLAR, "SECTIONS");


                PlayerPrefs.SetString(KY_TEXT_AYARLAR, "Options");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_SES, "Volume");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_DIL, "Language");
                PlayerPrefs.SetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA, "Delete All Data and Records");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_SIFIRLA, "Delete");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_HAKKIMIZDA, "About us");
                PlayerPrefs.SetString(KY_BUTTON_AYARLAR_ANA_MENU, "Main Menu");

                PlayerPrefs.SetString(KY_BUTTON_OYUN_BASLA, "Start");
                PlayerPrefs.SetString(KY_TEXT_OYUN_REKOR, "Record: ");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN, "Win!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN, "Lose!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN, "Mines");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_SURE, "Time");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE, "Move");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR, "Best time!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL, "Not Bad!!!");
                PlayerPrefs.SetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ, "Try Again!");


                break;
        }
    }

    public static void SetSes(float seviye)
    {
        PlayerPrefs.SetFloat(KY_SES, seviye);
    }
    public static float GetSes()
    {
        return PlayerPrefs.GetFloat(KY_SES);
    }
    public static string GetSistemDili()
    {
        return PlayerPrefs.GetString(KY_DIL);
    }public static string GetDilButtonAnaMenuOyna()
    {
        return PlayerPrefs.GetString(KY_BUTTON_ANA_MENU_OYNA);
    }
    
    public static string GetDilButtonAnaMenuAyarlar()
    {
        return PlayerPrefs.GetString(KY_BUTTON_ANA_MENU_AYARLAR);
    }
    public static string GetDilButtonAnaMenuCikis()
    {
        return PlayerPrefs.GetString(KY_BUTTON_ANA_MENU_CIKIS);
    }
    public static string GetBolumler()
    {
        return PlayerPrefs.GetString(KY_BOLUMLAR);
    }
    public static string GetDilTextUyariKutusuMayinSayisi()
    {
        return PlayerPrefs.GetString(KY_TEXT_ANA_MENU_UYARI_KUTUSU_MAYIN_SAYISI);
    }
    public static string GetDilButtonUyariKutusuBasla()
    {
        return PlayerPrefs.GetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_BASLA);
    }
    public static string GetDilButtonUyariKutusuIptal()
    {
        return PlayerPrefs.GetString(KY_BUTTON_ANA_MENU_UYARI_KUTUSU_IPTAL);
    }
    public static string GetDilAyarlarHeader()
    {
        return PlayerPrefs.GetString(KY_TEXT_AYARLAR);
    }
    public static string GetDilTextAyarlarSes()
    {
        return PlayerPrefs.GetString(KY_TEXT_AYARLAR_SES);
    }
    
    public static string GetDilTextAyarlarDil()
    {
        return PlayerPrefs.GetString(KY_TEXT_AYARLAR_DIL);
    }
    
    public static string GetDilTextAyarlarRekorlariSifirla()
    {
        return PlayerPrefs.GetString(KY_TEXT_AYARLAR_REKORLARI_SIFIRLA);
    }
    
    public static string GetDilButtontAyarlarSifirla()
    {
        return PlayerPrefs.GetString(KY_BUTTON_AYARLAR_SIFIRLA);
    }
    
    public static string GetDilButtontAyarlarHakkimizda()
    {
        return PlayerPrefs.GetString(KY_BUTTON_AYARLAR_HAKKIMIZDA);
    }
    
    public static string GetDilButtontAyarlarAnaMenu()
    {
        return PlayerPrefs.GetString(KY_BUTTON_AYARLAR_ANA_MENU);
    }
    
    public static string GetDilButtontOyunBasla()
    {
        return PlayerPrefs.GetString(KY_BUTTON_OYUN_BASLA);
    }
    
    public static string GetDilTexttOyunRekor()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_REKOR);
    }
    
    public static string GetDilTexttOyunOyunSonuKazandin()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN);
    }
    public static string GetDilTexttOyunOyunSonuKaybettin()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN);
    }
    public static string GetDilTexttOyunOyunSonuMayin()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_MAYIN);
    }
    public static string GetDilTexttOyunOyunSonuSure()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_SURE);
    }
    public static string GetDilTexttOyunOyunSonuHamle()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_HAMLE);
    }
    public static string GetDilTexttOyunOyunSonuKazandinRekor()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_REKOR);
    }
    public static string GetDilTexttOyunOyunSonuKazandinNormal()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_KAZANDIN_NORMAL);
    }
    public static string GetDilTexttOyunOyunSonuKaybettinMesaj()
    {
        return PlayerPrefs.GetString(KY_TEXT_OYUN_OYUN_SONU_KAYBETTIN_MESAJ);
    }



    public static void SetMayinSayisi(int mayinSayisi)
    {
        PlayerPrefs.SetInt(ANAHTAR_SECILI_MAYIN_SAYISI, mayinSayisi);
    }

    public static int GetMayinSayisi()
    {
        return PlayerPrefs.GetInt(ANAHTAR_SECILI_MAYIN_SAYISI);
    }
    public static void SetRekor(int bolum, int sure)
    {
       string key= ANAHTAR_REKOR_MAYIN_SAYISI+ bolum.ToString();
        if (PlayerPrefs.HasKey(key))
        {
            if (PlayerPrefs.GetInt(key) > sure)
            {
                PlayerPrefs.SetInt(key, sure);
            }
        }
        else
        {
            PlayerPrefs.SetInt(key, sure);

        }

    }
    public static int GetRekorSure(int bolum)
    {
        string key = ANAHTAR_REKOR_MAYIN_SAYISI + bolum.ToString();

        return PlayerPrefs.GetInt(key,10000);
        

        
    }

    public static string SureyiYaz(int sure)
    {
        string updtSure = "";
        if (sure >= 60)
        {
            if (sure / 60 > 9)
            {
                updtSure += sure / 60;
            }
            else
            {
                updtSure += "0" + sure / 60;
            }
            updtSure += ":";
            if (sure % 60 > 9)
            {
                updtSure += sure % 60;
            }
            else
            {
                updtSure += "0" + sure % 60;
            }
            return updtSure;
        }
        else
        {
            updtSure += "00:";
            if (sure > 9)
            {
                updtSure += sure;
            }
            else
            {
                updtSure += "0" + sure;
            }
            return updtSure;
        }
    }


    public static int GetSonAcikBolum() { return PlayerPrefs.GetInt("sonacikBolu", 1); }
    public static void SetSonAcikBolumArti(int acilanBolum) { PlayerPrefs.SetInt("sonacikBolu", GetSonAcikBolum()<acilanBolum?acilanBolum: GetSonAcikBolum()); }
    public static int GetRekorYildiz(int bolum) { return PlayerPrefs.GetInt("rekoryildiz"+bolum, 0); }
    public static void SetRekorYildiz(int bolum,int yildiz) { PlayerPrefs.SetInt("rekoryildiz" + bolum, yildiz); }

    public static void ButuKayitlariSil()
    {
        PlayerPrefs.DeleteAll();
    }

    public static void SetSayfaKonum(float transformY) { PlayerPrefs.SetFloat("konumsayfa", transformY); }
    public static float GetSayfaKonum() { return PlayerPrefs.GetFloat("konumsayfa", -4800)<-4800?-4800: PlayerPrefs.GetFloat("konumsayfa", -4800); }
}
