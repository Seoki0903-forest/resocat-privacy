[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · **Português (Brasil)** · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Defina uma resolução de tela personalizada para cada aplicativo Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Ferramenta gratuita para configurar as permissões iniciais do ResoCat em um celular ou tablet Android conectado por USB a um PC Windows. Requer Windows 10/11 de 64 bits e .NET Framework 4.5+. O EXE inclui o ADB; não é necessário instalar separadamente nem extrair arquivos. A interface fica em coreano no Windows em coreano e em inglês nos demais sistemas. Este guia abrange os 13 idiomas do ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Código-fonte](usb-helper/source/ResoCatAdbHelper.cs)

## Como usar

1. Instale o ResoCat pelo Google Play no dispositivo Android.
2. Ative a depuração USB nas Opções do desenvolvedor. Normalmente, toque sete vezes em Configurações → Sobre o telefone → Número da versão para ativá-las. Os nomes variam conforme o fabricante.
3. Conecte um cabo USB de dados e desbloqueie o dispositivo.
4. Autorize este computador no aviso de depuração USB do dispositivo. Não selecione “Sempre permitir” em um PC compartilhado.
5. Execute `ResoCat-ADB-Helper.exe` baixado do repositório oficial no GitHub.
6. Selecione o dispositivo e clique em **Set permissions and open ResoCat**. Se houver apenas um dispositivo, ele será selecionado automaticamente.
7. Confira a mensagem de conclusão e revise os termos e demais configurações no ResoCat. Depois, pode desconectar o USB.

Problemas de conexão: Para `unauthorized`, desbloqueie o dispositivo, autorize a depuração e clique em **Refresh devices**. Para `offline`, reconecte o USB. Se nenhum dispositivo aparecer, confira a depuração USB, o cabo e os drivers USB do fabricante. Se a conclusão for parcial, permita o acesso ao uso nas configurações Android indicadas pelo ResoCat. Restrições do fabricante e políticas de dispositivos gerenciados não são contornadas.

Aviso do Windows: O programa não tem assinatura digital e pode exibir “O Windows protegeu o computador”. Confira a URL oficial e o SHA-256; escolha “Mais informações → Executar assim mesmo” somente para um arquivo em que você confia.

Alterações: Somente `WRITE_SECURE_SETTINGS` e `GET_USAGE_STATS` do ResoCat (`app.resocat.switcher`) no usuário Android ativo. Não exige root nem administrador do PC. Não muda resolução/DPI, anúncios, pagamentos ou bateria, não instala aplicativos, não apaga dados e não envia dados a servidores. O TXT de **Save result** pode incluir identificadores do dispositivo; envie-o ao suporte por conta própria se necessário. A depuração USB pode ser desativada depois da configuração.
