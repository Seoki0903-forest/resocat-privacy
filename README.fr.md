[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · **Français** · [Türkçe](README.tr.md)

# ResoCat

Définissez une résolution d’écran pour chaque application Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Télécharger

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Outil gratuit pour configurer les autorisations initiales de ResoCat sur un téléphone ou une tablette Android connecté en USB à un PC Windows. Nécessite Windows 10/11 64 bits et .NET Framework 4.5+. Il suffit de télécharger cet unique EXE. La première utilisation nécessite Internet : le programme télécharge automatiquement Android platform-tools 37.0.1 directement depuis Google et vérifie SHA-256 avant utilisation. Les outils vérifiés sont conservés dans `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` pour une utilisation hors ligne ultérieure. ADB n’est plus intégré à l’EXE ni exécuté depuis un dossier temporaire. L’interface du programme est en anglais sur tous les systèmes Windows. Ce guide couvre les 13 langues de ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Code source](usb-helper/source/ResoCatAdbHelper.cs)

## Mode d’emploi

1. Installez ResoCat depuis Google Play sur l’appareil Android.
2. Activez le débogage USB dans les Options pour les développeurs. Généralement, touchez sept fois Paramètres → À propos du téléphone → Numéro de build pour les activer. Les noms varient selon le fabricant.
3. Connectez un câble USB permettant le transfert de données et déverrouillez l’appareil.
4. Autorisez cet ordinateur dans la demande de débogage USB sur l’appareil. Ne cochez pas « Toujours autoriser » sur un PC partagé.
5. Lancez `ResoCat-ADB-Helper.exe` téléchargé depuis le dépôt GitHub officiel.
6. Sélectionnez l’appareil et cliquez sur **Set permissions and open ResoCat**. Un seul appareil connecté est sélectionné automatiquement.
7. Vérifiez le message de fin puis consultez vous-même les conditions et réglages restants dans ResoCat. Vous pouvez ensuite débrancher l’USB.

### Boutons

- **Refresh devices** — Recherche les appareils ou actualise la liste.
- **Set permissions and open ResoCat** — Configure les autorisations de l’appareil sélectionné et ouvre ResoCat. Cliquez sur ce bouton pour lancer la configuration.
- **Save result** — Enregistre le résultat dans un fichier TXT si vous avez besoin d’aide. Cette étape est facultative.

Problèmes de connexion : Pour `unauthorized`, déverrouillez l’appareil, autorisez le débogage et cliquez sur **Refresh devices**. Pour `offline`, reconnectez l’USB. Si aucun appareil n’apparaît, vérifiez le débogage USB, le câble de données et les pilotes USB du fabricant. En cas de résultat partiel, autorisez l’accès aux données d’utilisation dans les paramètres Android indiqués par ResoCat. Les restrictions du fabricant et politiques des appareils gérés ne sont pas contournées.

Avertissement Windows : Ce programme n’est pas signé et peut afficher « Windows a protégé votre ordinateur ». Vérifiez l’URL officielle et le SHA-256 ; choisissez « Informations complémentaires → Exécuter quand même » uniquement pour un fichier de confiance.

Modifications : Uniquement `WRITE_SECURE_SETTINGS` et `GET_USAGE_STATS` pour ResoCat (`app.resocat.switcher`) de l’utilisateur Android actif. Aucun root ni droit administrateur du PC requis. Aucun changement de résolution/DPI, publicité, paiement ou batterie ; aucune installation d’application, suppression de données ou transmission à un serveur. Le TXT de **Save result** peut contenir des identifiants de l’appareil ; envoyez-le vous-même au support si nécessaire. Le débogage USB peut être désactivé après la configuration.

## Contact

[Site web](https://seokiapps.com/) · [Nous contacter](https://seokiapps.com/en/support/)
