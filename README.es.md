[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · **Español** · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Configura una resolución de pantalla para cada aplicación Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Descargar

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Herramienta gratuita para configurar los permisos iniciales de ResoCat en un teléfono o tableta Android conectado por USB a un PC Windows. Requiere Windows 10/11 de 64 bits y .NET Framework 4.5+. El EXE incluye ADB; no requiere instalación adicional ni extracción. La interfaz está en coreano en Windows configurado en coreano y en inglés en los demás sistemas. Esta guía cubre los 13 idiomas de ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Código fuente](usb-helper/source/ResoCatAdbHelper.cs)

## Instrucciones de uso

1. Instala ResoCat desde Google Play en el dispositivo Android.
2. Activa la depuración USB en Opciones de desarrollador. Normalmente se habilitan tocando siete veces Ajustes → Información del teléfono → Número de compilación. Los nombres varían según el fabricante.
3. Conecta un cable USB de datos y desbloquea el dispositivo.
4. Autoriza este ordenador en el aviso de depuración USB del dispositivo. No marques “Permitir siempre” en un PC compartido.
5. Ejecuta `ResoCat-ADB-Helper.exe` descargado del repositorio oficial de GitHub.
6. Selecciona el dispositivo y pulsa **Set permissions and open ResoCat**. Si solo hay uno conectado, se selecciona automáticamente.
7. Comprueba el mensaje de finalización y revisa personalmente los términos y ajustes restantes en ResoCat. Después puedes desconectar el USB.

Problemas de conexión: Para `unauthorized`, desbloquea el dispositivo, autoriza la depuración y pulsa **Refresh devices**. Para `offline`, reconecta el USB. Si no aparece ningún dispositivo, comprueba la depuración USB, el cable y los controladores USB del fabricante. Si el resultado es parcial, habilita el acceso de uso en los ajustes Android indicados por ResoCat. No se eluden restricciones del fabricante ni políticas de dispositivos administrados.

Aviso de Windows: El programa no tiene firma digital y puede mostrar “Windows protegió su PC”. Verifica la URL oficial y el SHA-256; elige “Más información → Ejecutar de todas formas” solo si confías en el archivo.

Cambios: Solo configura `WRITE_SECURE_SETTINGS` y `GET_USAGE_STATS` para ResoCat (`app.resocat.switcher`) en el usuario Android activo. No requiere root ni permisos de administrador del PC. No cambia resolución/DPI, anuncios, pagos ni batería; no instala aplicaciones, borra datos ni envía datos a servidores. El TXT de **Save result** puede incluir identificadores del dispositivo; envíalo tú mismo al soporte si lo necesitas. Puedes desactivar la depuración USB al terminar.
