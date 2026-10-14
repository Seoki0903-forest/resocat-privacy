[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · **Deutsch** · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Lege für jede Android-App eine eigene Bildschirmauflösung fest.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Kostenloses Werkzeug zum Einrichten der anfänglichen ResoCat-Berechtigungen auf einem Android-Handy oder -Tablet, das per USB mit einem Windows-PC verbunden ist. Benötigt 64-Bit-Windows 10/11 und .NET Framework 4.5+. ADB ist in der EXE enthalten; keine separate Installation oder Entpackung nötig. Die Oberfläche ist auf koreanischem Windows koreanisch, sonst englisch. Diese Anleitung enthält alle 13 ResoCat-Sprachen.

[SHA-256](downloads/SHA256SUMS.txt) · [Quellcode](usb-helper/source/ResoCatAdbHelper.cs)

## Anleitung

1. Installiere ResoCat über Google Play auf dem Android-Gerät.
2. Aktiviere USB-Debugging in den Entwickleroptionen. Diese werden meist durch siebenmaliges Tippen auf Einstellungen → Über das Telefon → Build-Nummer aktiviert. Menübezeichnungen variieren je nach Hersteller.
3. Verbinde ein USB-Datenkabel und entsperre das Gerät.
4. Erlaube diesen Computer in der USB-Debugging-Abfrage auf dem Gerät. Wähle auf gemeinsam genutzten PCs nicht „Immer zulassen“.
5. Starte `ResoCat-ADB-Helper.exe` aus dem offiziellen GitHub-Repository.
6. Wähle dein Gerät und klicke auf **Set permissions and open ResoCat**. Ein einzelnes verbundenes Gerät wird automatisch ausgewählt.
7. Prüfe die Abschlussmeldung und bestätige die Bedingungen und übrigen Einstellungen selbst in ResoCat. Danach kannst du USB trennen.

Verbindungsprobleme: Bei `unauthorized` Gerät entsperren, USB-Debugging erlauben und **Refresh devices** klicken. Bei `offline` USB neu verbinden. Wenn kein Gerät erscheint, USB-Debugging, Datenkabel und Hersteller-USB-Treiber prüfen. Bei teilweisem Abschluss den Zugriff auf Nutzungsdaten in den von ResoCat angegebenen Android-Einstellungen erlauben. Herstellerbeschränkungen und Richtlinien verwalteter Geräte werden nicht umgangen.

Windows-Warnung: Das Programm ist nicht digital signiert und kann „Der Computer wurde durch Windows geschützt“ auslösen. Offizielle Download-URL und SHA-256 prüfen; „Weitere Informationen → Trotzdem ausführen“ nur für eine vertrauenswürdige Datei wählen.

Änderungen: Nur `WRITE_SECURE_SETTINGS` und `GET_USAGE_STATS` für ResoCat (`app.resocat.switcher`) beim aktiven Android-Benutzer. Root oder PC-Administratorrechte sind nicht nötig. Auflösung/DPI, Werbung, Zahlungen und Akkueinstellungen bleiben unverändert. Keine App-Installation, Datenlöschung oder Übertragung an Server. Die TXT aus **Save result** kann Gerätekennungen enthalten; sende sie bei Bedarf selbst an den Support. USB-Debugging kann danach deaktiviert werden.
