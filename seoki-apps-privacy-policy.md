# Seoki Apps Website Privacy Policy

[English](#privacy-en) · [한국어](#privacy-ko) · [Español](#privacy-es) · [Português (Brasil)](#privacy-pt-br) · [简体中文](#privacy-zh-hans) · [हिन्दी](#privacy-hi) · [العربية](#privacy-ar) · [Français](#privacy-fr) · [日本語](#privacy-ja) · [Bahasa Indonesia](#privacy-id)

<a name="privacy-en"></a>
<div lang="en" dir="ltr">

## English · Seoki Apps · Privacy policy

Effective date: 2026-11-07

Seoki Apps operates seokiapps.com from the Republic of Korea. This policy covers the homepage, general website pages, visitor statistics, customer support and error reports submitted to the website. Table and file processing in Table Converter has a separate policy; consult each other app’s own policy for its processing. Send privacy questions and rights requests to contact@seokiapps.com.

[Table converter · Privacy policy](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-en)

### Visitor statistics and exclusion

Regular pages and web tools store a random browser ID and the last counted date in localStorage to avoid duplicate visits. Per-tool date keys use seoki-tool-day:\<tool\>. The server stores a SHA-256 hash of the ID, the date and an allowlisted tool identifier to calculate site-wide and per-tool daily, weekly and monthly visitors. Tool counts combine all interface languages and do not count refreshes twice. The statistics API does not store names, emails, raw IPs, visited URLs, table content or screen images. Hashed identifiers are not considered fully anonymous. Country statistics also store the connection country code supplied by Cloudflare with the identifier hash and date. Raw IPs, cities and precise locations are not stored in these statistics; VPNs may affect the country estimate. The browser also stores the last country-counting dates for the site and tools.

Identifier hashes and counts currently have no automatic expiry. Browser identifiers are removed by clearing site data or enabling exclusion below. Contact us about server records. Exclusion, GPC or Do Not Track prevents subsequent visit-count requests.

[Exclude this browser from visitor statistics](https://seokiapps.com/en/privacy-settings/)

### Support messages and email

Support requires the app name, subject, message, language and submission time; email and a post password are optional. Without a password, messages and replies are public. Subjects and app names remain public even with a password. Email is not shown on the board. Passwords are stored as verification hashes and encrypted copies recoverable by the administrator; do not reuse passwords from other services.

New messages and supplied email addresses pass through Brevo for operator notifications. If you provide an email, reply notifications may include the inquiry and reply. Messages and replies older than 180 days become eligible for cleanup when a new inquiry is submitted, rather than deletion at an exact scheduled time. Contact us for earlier deletion. Direct emails and mail-provider records may remain separately.

### App error reports and abuse prevention

We accept app error reports only when users consent to sending them. App and OS versions, platform, device description, symptoms, logs, report ID and submission time help resolve errors. Known email and credential patterns are redacted, but detection is not complete; check the report before sending. ZZZ Disk Reader recognition reports also include the screenshot selected by the user, recognition language, permission/model status, and recent recognition/crash records. Reports are sent over HTTPS only after pressing Send and are visible only to the administrator. Images are removed with logs after 30 days. Images are not automatically redacted; cover unwanted details such as your UID before sending. For Table Converter reports, descriptions, URLs, browser information and optional reproduction files up to 8 MB are submitted only by the user and used to diagnose problems and improve the tool. Workspace tables are not sent automatically. Only administrators can download attachments; personal information in files is not automatically masked. Attachments follow the same retention and cleanup rules as error logs.

Logs older than 30 days are cleaned up during submissions or administrator listings, with a limit of 1,000 reports. Report ID, app, content hash and time used for duplicate prevention and weekly counts are stored separately without automatic expiry. Some APIs use temporary hashes combining IP, a secret and a time window to prevent abuse, without storing raw IPs in those records.

### Browser storage and cookies

localStorage holds language choice (seoki-language), table UI settings (seoki-table-ui), panel state (seoki-table-panels), and statistics ID, date and exclusion preferences. These have no fixed expiry and can be removed through browser site-data settings. Blocking storage limits saved preferences. The site does not create its own login cookie for ordinary visitors.

Only administrators receive a secure session cookie (\_\_Host-seoki-admin, up to one hour). Hosting and security providers may process cookies and connection records under their own policies. Clearing browser data does not delete server-side inquiries or existing statistics.

### Hosting, email providers and external links

Cloudflare provides page delivery, security, APIs and the database, and may process technical connection data such as IP, request time and browser information. Brevo handles inquiry and reply emails. Hosting and email data may be processed outside the Republic of Korea depending on provider infrastructure and settings; their policies below explain provider retention and transfers. After five consecutive incorrect administrator passwords, Cloudflare Turnstile performs human verification and may process IP, browser and security signals. Tokens are verified on the server and are not stored. Consecutive failures per IP use a temporary hash; ten failures trigger a 15-minute block.

We do not sell document contents or share them for advertising. Sharing outside the stated purposes is limited to necessary service/security processing or legal requirements. App stores, social media and other external destinations have their own policies.

### Advertising and personalization choices

Live advertising is currently disabled on this website. The AdSense verification meta tag and ads.txt provide site verification information and do not load ads by themselves. This notice and required consent arrangements will be applied before advertising is enabled.

If Google advertising is introduced, third-party vendors including Google may use advertising cookies to serve ads based on earlier visits to this or other sites. Google and its partners may use those cookies for personalized ads. Manage personalization through Google’s advertising settings or the industry choice page linked below. Table contents are not supplied for advertising.

### Your rights, safeguards and policy changes

Contact us below to request access, correction, deletion, restriction or withdrawal of consent. We may ask for minimal verification such as a post or report ID. Do not post identity documents or sensitive information publicly. Withholding required fields may prevent support submission or email notifications but does not prevent table conversion.

We use administrator access controls, HTTPS, and password hashing/encryption. Records marked for deletion are removed from the database; provider backups and mail copies may follow separate retention procedures. This page and its effective date will be updated when data categories, purposes, advertising or provider processing change.

### Privacy information from related services

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

Privacy contact: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-ko"></a>
<div lang="ko" dir="ltr">

## 한국어 · Seoki Apps · 개인정보처리방침

시행일: 2026-11-07

Seoki Apps는 대한민국에서 seokiapps.com을 운영합니다. 이 방침은 홈페이지와 일반 웹페이지의 방문 통계, 고객센터 및 사이트에 접수한 오류 보고에 적용됩니다. 표 변환기의 표·파일 처리에는 별도 방침이 적용되며, 다른 앱의 이용은 해당 앱의 방침도 확인해 주세요. 개인정보 관련 문의와 권리 요청은 contact@seokiapps.com으로 보내 주세요.

[표 변환기 · 개인정보처리방침](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-ko)

### 방문 통계와 수집 제외

일반 페이지와 웹 도구에서는 중복 방문 계산을 위해 임의 브라우저 식별자와 마지막 집계 날짜를 localStorage에 저장합니다. 도구별 날짜 키는 seoki-tool-day:\<tool\>입니다. 서버에는 식별자의 SHA-256 해시와 날짜, 정해진 도구 구분값을 저장해 사이트 전체 및 도구별 일·주·월 방문 수를 계산합니다. 도구별 집계는 언어를 합산하며 새로고침을 중복 계산하지 않습니다. 통계 API에는 이름·이메일·원시 IP·방문 URL·표 내용·화면 이미지를 저장하지 않습니다. 해시 식별자는 완전한 익명 정보라고 간주하지 않습니다. 국가별 통계를 위해 Cloudflare가 제공하는 접속 국가 코드도 식별자 해시·날짜와 함께 저장합니다. 원본 IP·도시·정확한 위치는 이 통계에 저장하지 않으며, 국가 추정은 VPN 등에 따라 실제 위치와 다를 수 있습니다. 일반 페이지와 도구별 국가 집계 날짜도 브라우저에 저장합니다.

식별자 해시와 집계에는 현재 자동 만료가 설정되어 있지 않습니다. 브라우저 식별자는 사이트 데이터를 지우거나 아래에서 수집 제외를 켜면 삭제됩니다. 서버 기록 관련 요청은 연락처로 문의해 주세요. 수집 제외, GPC 또는 Do Not Track이 활성화되면 이후 방문 집계 요청을 보내지 않습니다.

[이 브라우저의 방문 통계 수집 제외](https://seokiapps.com/ko/privacy-settings/)

### 고객센터 문의와 이메일

문의 처리에는 앱 이름·제목·본문·언어·접수 시각이 필요하며 이메일과 글 비밀번호는 선택 항목입니다. 비밀번호가 없으면 본문과 답변도 공개되고, 비밀번호를 설정해도 제목과 앱 이름은 공개됩니다. 이메일은 게시판에 공개하지 않습니다. 비밀번호는 검증용 해시와 관리자 복구용 암호화본으로 보관하므로 다른 서비스의 비밀번호를 재사용하지 마세요.

새 문의의 내용과 입력한 이메일은 운영자 알림을 위해 Brevo 이메일 서비스를 거치며, 이메일을 입력한 경우 답변 알림에도 문의·답변 내용이 포함될 수 있습니다. 문의와 답변은 접수 후 180일이 지나면 새 문의 접수 시 정리 대상이 됩니다. 정확한 시각의 자동 삭제를 보장하지 않으며 먼저 삭제하려면 연락해 주세요. 직접 보낸 이메일과 메일 서비스의 기록은 별도로 남을 수 있습니다.

### 앱 오류 보고와 남용 방지

앱에서 이용자가 전송에 동의한 오류 보고서만 접수합니다. 앱·OS 버전, 플랫폼, 기기 설명, 증상, 로그, 보고서 ID와 접수 시각을 오류 해결에 사용합니다. 알려진 이메일·인증정보 등을 가리는 처리를 하지만 모든 민감 정보를 찾아내지는 못하므로 제출 전 확인해 주세요. ZZZ디스크판독기의 인식 오작동 제보에는 이용자가 선택한 화면 사진, 인식 언어, 권한·모델 상태, 최근 인식·비정상 종료 기록도 포함됩니다. 발송 버튼을 누른 경우에만 HTTPS로 접수하며 관리자만 조회합니다. 사진도 로그와 함께 30일 후 정리합니다. 사진의 개인정보는 자동으로 가려지지 않으므로 제출 전 UID 등 원치 않는 내용을 가려주세요. 표 변환기의 오류 보고에서 이용자가 직접 제출한 설명·웹 주소·브라우저 정보와 선택한 재현 파일(선택 사항, 최대 8 MB)을 오류 해결과 개선에 사용합니다. 작업 중인 표는 자동 전송하지 않습니다. 첨부 파일은 관리자만 내려받을 수 있으며 파일 속 개인정보를 자동으로 가리지 않습니다. 첨부도 오류 로그와 같은 보관·정리 기준을 적용합니다.

오류 로그는 30일이 지난 자료를 접수·관리자 조회 시 정리하며 최대 1,000건으로 제한합니다. 중복 전송 방지와 주간 집계용 보고서 ID·앱·내용 해시·접수 시각은 로그 원문과 별도로 보관하고 현재 자동 만료가 없습니다. 일부 API는 남용 방지를 위해 IP와 비밀값·시간 구간을 조합한 임시 해시를 사용하며 원시 IP를 해당 기록에 저장하지 않습니다.

### 브라우저 저장소와 쿠키

언어 선택(seoki-language), 표의 UI 설정(seoki-table-ui), 패널 상태(seoki-table-panels), 통계 식별자·날짜·제외 설정은 localStorage에 저장합니다. 별도 만료가 없으며 브라우저의 사이트 데이터 삭제로 지울 수 있습니다. 저장소를 막으면 설정 유지가 제한됩니다. 일반 방문자에게 사이트 자체의 로그인 쿠키를 만들지 않습니다.

관리자 로그인에만 보안 세션 쿠키(\_\_Host-seoki-admin, 최대 1시간)를 사용합니다. 호스팅·보안 제공자의 쿠키와 연결 기록에는 해당 서비스의 정책도 적용됩니다. 브라우저 저장소 삭제만으로 서버 문의나 이미 생성된 통계가 삭제되지는 않습니다.

### 호스팅·메일 제공자와 외부 링크

Cloudflare는 페이지 전달·보안·API와 데이터베이스를 제공하며 연결 과정에서 IP·요청 시각·브라우저 정보 같은 기술 정보를 처리할 수 있습니다. Brevo는 문의 및 답변 이메일 전송을 처리합니다. 호스팅·메일 데이터는 공급자의 인프라와 설정에 따라 대한민국 밖에서 처리될 수 있으며 공급자별 보관·이전 조건은 아래 안내를 확인할 수 있습니다. 관리자 로그인에서 비밀번호가 5회 연속 틀리면 Cloudflare Turnstile로 사람 확인을 진행하며, Cloudflare가 IP·브라우저 및 보안 신호를 처리할 수 있습니다. 확인 토큰은 서버에서 검증하고 저장하지 않습니다. IP별 연속 실패 횟수는 임시 해시로 관리하며 10회 실패 시 15분간 차단합니다.

문서 내용을 판매하거나 광고 목적으로 제공하지 않습니다. 운영·보안에 필요한 공급자 처리 또는 법령상 요구가 있는 경우를 제외하고 목적 밖 공유를 하지 않습니다. 앱 스토어·SNS 등 외부 링크를 방문하면 해당 사이트의 방침이 적용됩니다.

### 광고와 맞춤 광고 선택

현재 이 웹사이트의 실광고는 비활성입니다. 애드센스 인증 메타 태그와 ads.txt는 사이트 확인 정보이며 그 자체로 광고를 불러오지 않습니다. 실제 광고를 활성화하기 전에 이 안내와 필요한 동의 절차를 적용합니다.

Google 광고를 도입하면 Google을 포함한 제3자 업체가 이 사이트나 다른 사이트의 이전 방문을 바탕으로 광고 쿠키를 사용하고 광고를 게재할 수 있습니다. Google과 파트너의 광고 쿠키는 맞춤 광고에 사용될 수 있으며, 아래 Google 광고 설정 또는 업계 광고 선택 페이지에서 맞춤 광고를 관리할 수 있습니다. 표 내용은 광고에 제공하지 않습니다.

### 이용자 권리·보호와 방침 변경

본인 데이터의 열람·정정·삭제·처리 정지나 동의 철회는 아래 연락처로 요청할 수 있습니다. 게시글·보고서 ID 등 최소한의 확인 정보를 요청할 수 있으며 신분증이나 민감 정보를 공개 게시판에 올리지 마세요. 필요한 항목을 제공하지 않으면 문의 접수나 이메일 알림이 제한될 수 있지만 표 변환은 계속 이용할 수 있습니다.

관리자 접근 제한, HTTPS, 글 비밀번호의 해시·암호화 등을 사용합니다. 삭제 대상 전자 기록은 데이터베이스에서 제거하며 공급자 백업·메일 사본에는 별도 보관 절차가 적용될 수 있습니다. 데이터 항목·목적·광고 또는 제공자 처리가 바뀌면 이 페이지의 내용과 시행일을 갱신합니다.

### 관련 서비스의 개인정보 안내

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

개인정보 문의: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-es"></a>
<div lang="es" dir="ltr">

## Español · Seoki Apps · Política de privacidad

Fecha de entrada en vigor: 2026-11-07

Seoki Apps opera seokiapps.com desde la República de Corea. Esta política cubre la página principal, las páginas generales, las estadísticas de visitas, la atención al cliente y los informes de errores enviados al sitio. El tratamiento de tablas y archivos del Conversor de tablas tiene una política independiente; consulte también la política de cada otra aplicación. Para consultas y solicitudes sobre privacidad, escriba a contact@seokiapps.com.

[Conversor de tablas · Política de privacidad](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-es)

### Estadísticas y exclusión

Las páginas generales y herramientas web guardan un identificador aleatorio del navegador y la última fecha contabilizada en localStorage para evitar duplicados. Las claves de fecha por herramienta usan seoki-tool-day:\<tool\>. El servidor guarda un hash SHA-256 del identificador, la fecha y un identificador de herramienta permitido para calcular visitantes diarios, semanales y mensuales del sitio y de cada herramienta. Se suman todos los idiomas y las recargas no duplican el recuento. La API no guarda nombres, correos, IP sin procesar, URL visitadas, contenido de tablas ni imágenes de pantalla. Los identificadores con hash no se consideran totalmente anónimos. Las estadísticas por país también guardan el código de país de conexión proporcionado por Cloudflare junto con el hash y la fecha. No se guardan IP sin procesar, ciudades ni ubicaciones precisas; una VPN puede alterar la estimación. El navegador guarda también las últimas fechas del recuento por país del sitio y las herramientas.

Los hashes y recuentos no tienen caducidad automática. El identificador local se elimina borrando datos del sitio o activando la exclusión. Consúltanos sobre registros del servidor. La exclusión, GPC o Do Not Track impiden futuras solicitudes de recuento.

[Excluir este navegador de las estadísticas](https://seokiapps.com/es/privacy-settings/)

### Consultas y correo

Las consultas requieren aplicación, asunto, mensaje, idioma y fecha; correo y contraseña del mensaje son opcionales. Sin contraseña, mensaje y respuestas son públicos. El asunto y la aplicación siempre son públicos; el correo no se muestra. La contraseña se guarda como hash de verificación y copia cifrada recuperable por el administrador: no reutilices otras contraseñas.

Brevo transmite las consultas y el correo facilitado para avisar al operador; los avisos de respuesta pueden incluir consulta y respuesta. Los registros de más de 180 días se limpian al recibir nuevas consultas, sin garantizar una hora exacta. Solicita una eliminación anterior por correo. Los mensajes directos y registros del proveedor pueden permanecer aparte.

### Errores y prevención de abuso

Solo recibimos informes enviados con consentimiento desde una app: versiones de app y sistema, plataforma, descripción del dispositivo, síntomas, registros, ID y fecha. Se ocultan patrones conocidos de correos y credenciales, pero no se detecta todo; revisa antes de enviar. Los informes de reconocimiento de ZZZ Disk Reader también incluyen la captura elegida, el idioma de reconocimiento, el estado de permisos y modelos y registros recientes de reconocimiento y fallos. Solo se envían por HTTPS al pulsar Enviar y únicamente el administrador puede verlos. Las imágenes se eliminan con los registros a los 30 días. No se ocultan datos de la imagen automáticamente; tape detalles como su UID antes de enviarla. En los informes del convertidor de tablas, el usuario envía la descripción, URL, información del navegador y, opcionalmente, un archivo de hasta 8 MB para diagnosticar problemas y mejorar la herramienta. Las tablas de trabajo no se envían automáticamente. Solo los administradores pueden descargar adjuntos; sus datos personales no se ocultan automáticamente. Se aplican las mismas reglas de conservación y limpieza que a los registros.

Los registros de más de 30 días se limpian durante envíos o consultas del administrador, con un máximo de 1.000 informes. ID, aplicación, hash del contenido y fecha se conservan aparte para duplicados y recuentos semanales sin caducidad automática. Algunas API usan hashes temporales de IP, secreto e intervalo para prevenir abuso, sin guardar la IP original en esos registros.

### Almacenamiento y cookies

localStorage conserva idioma (seoki-language), ajustes de tablas (seoki-table-ui), paneles (seoki-table-panels) e ID, fecha y exclusión estadística. No caducan automáticamente; puedes borrarlos en los datos del sitio. Bloquearlos limita las preferencias guardadas. No creamos cookies propias de inicio de sesión para visitantes normales.

Solo el administrador recibe la cookie segura \_\_Host-seoki-admin, de hasta una hora. Los proveedores de alojamiento y seguridad pueden tratar cookies y conexiones según sus políticas. Borrar datos locales no elimina consultas ni estadísticas del servidor.

### Proveedores y enlaces externos

Cloudflare proporciona páginas, seguridad, API y base de datos y puede procesar IP, hora de solicitud e información del navegador. Brevo gestiona correos de consultas y respuestas. Según infraestructura y ajustes, estos datos pueden tratarse fuera de Corea; consulta las políticas enlazadas sobre conservación y transferencias. Tras cinco contraseñas de administrador incorrectas seguidas, Cloudflare Turnstile realiza una verificación humana y puede tratar la IP, el navegador y señales de seguridad. Los tokens se validan en el servidor y no se almacenan. Los fallos por IP se vinculan a un hash temporal; diez fallos bloquean el acceso durante 15 minutos.

No vendemos documentos ni los compartimos para publicidad. El tratamiento fuera de los fines indicados se limita a servicios y seguridad necesarios u obligaciones legales. Tiendas de apps, redes sociales y otros sitios enlazados tienen sus propias políticas.

### Publicidad y personalización

Los anuncios reales están desactivados. La etiqueta de verificación de AdSense y ads.txt no cargan anuncios por sí mismos. Antes de activarlos se aplicarán este aviso y los mecanismos de consentimiento necesarios.

Si se incorpora publicidad de Google, proveedores como Google podrán utilizar cookies publicitarias según visitas anteriores a este u otros sitios. Google y sus socios pueden usarlas para personalizar anuncios. Gestiona tus preferencias en los ajustes de publicidad de Google o la página de elección del sector enlazados. El contenido de las tablas no se proporciona para anuncios.

### Derechos, protección y cambios

Escríbenos para solicitar acceso, corrección, eliminación, limitación o retirada del consentimiento. Podemos pedir una verificación mínima, como el ID del mensaje o informe. No publiques documentos de identidad ni datos sensibles. Omitir datos necesarios puede limitar las consultas o los avisos, pero no la conversión de tablas.

Usamos acceso administrativo restringido, HTTPS y hashes/cifrado de contraseñas. Los registros a eliminar se retiran de la base de datos; copias del proveedor o de correo pueden seguir otros plazos. Actualizaremos esta página y su fecha cuando cambien datos, fines, publicidad o proveedores.

### Privacidad de servicios relacionados

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

Contacto de privacidad: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-pt-br"></a>
<div lang="pt-BR" dir="ltr">

## Português (Brasil) · Seoki Apps · Política de privacidade

Vigência: 2026-11-07

A Seoki Apps opera seokiapps.com a partir da República da Coreia. Esta política abrange a página inicial, as páginas gerais, as estatísticas de visitas, o atendimento e os relatos de erros enviados ao site. O processamento de tabelas e arquivos do Conversor de tabelas tem uma política separada; consulte também a política de cada outro aplicativo. Envie dúvidas e solicitações de privacidade para contact@seokiapps.com.

[Conversor de tabelas · Política de privacidade](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-pt-br)

### Estatísticas e exclusão

Páginas comuns e ferramentas web armazenam um identificador aleatório do navegador e a última data contabilizada no localStorage para evitar duplicações. As chaves de data por ferramenta usam seoki-tool-day:\<tool\>. O servidor armazena o hash SHA-256 do identificador, a data e um identificador de ferramenta permitido para calcular visitantes diários, semanais e mensais do site e de cada ferramenta. Os idiomas são somados e recarregar não duplica a contagem. A API não armazena nomes, e-mails, IPs brutos, URLs visitadas, conteúdo de tabelas nem imagens da tela. Identificadores com hash não são considerados totalmente anônimos. As estatísticas por país também guardam o código do país da conexão fornecido pela Cloudflare junto ao hash e à data. Não guardam IPs brutos, cidades nem localização precisa; VPNs podem afetar a estimativa. O navegador também guarda as últimas datas da contagem por país do site e das ferramentas.

Hashes e contagens não têm expiração automática. Apagar os dados do site ou ativar a exclusão remove o identificador local. Fale conosco sobre registros do servidor. Exclusão, GPC ou Do Not Track impedem novas solicitações de contagem.

[Excluir este navegador das estatísticas](https://seokiapps.com/pt-BR/privacy-settings/)

### Atendimento e email

O atendimento exige aplicativo, assunto, mensagem, idioma e data; email e senha da postagem são opcionais. Sem senha, mensagem e respostas são públicas. Assunto e aplicativo sempre são públicos; o email não aparece no mural. Senhas ficam como hash de verificação e cópia criptografada recuperável pelo administrador: não reutilize senhas.

Consultas e emails informados passam pelo Brevo para avisar o operador. Avisos de resposta podem conter a consulta e a resposta. Registros com mais de 180 dias são elegíveis para limpeza durante novos contatos, sem horário exato de exclusão. Peça exclusão antecipada por email. Mensagens diretas e registros do provedor podem permanecer separadamente.

### Erros e prevenção de abuso

Recebemos relatórios enviados no aplicativo apenas com consentimento: versões do app e sistema, plataforma, descrição do aparelho, sintomas, logs, ID e data. Padrões conhecidos de emails e credenciais são ocultados, mas a detecção não é completa. Revise antes de enviar. Relatos de reconhecimento do ZZZ Disk Reader também incluem a captura escolhida, idioma de reconhecimento, estado de permissões e modelos e registros recentes de reconhecimento e falhas. Só são enviados por HTTPS ao tocar em Enviar e apenas o administrador pode acessá-los. Imagens são removidas com os registros após 30 dias. Dados na imagem não são ocultados automaticamente; cubra detalhes como seu UID antes de enviar. Nos relatos do Conversor de tabelas, o usuário envia a descrição, URL, informações do navegador e, opcionalmente, um arquivo de até 8 MB para diagnosticar problemas e melhorar a ferramenta. As tabelas de trabalho não são enviadas automaticamente. Apenas administradores podem baixar anexos; seus dados pessoais não são ocultados automaticamente. Aplicam-se as mesmas regras de retenção e limpeza dos registros.

Logs com mais de 30 dias são removidos durante envios ou consultas administrativas, com limite de 1.000 relatórios. ID, app, hash do conteúdo e data permanecem separados para evitar duplicações e contar relatórios semanais, sem expiração automática. Algumas APIs usam hashes temporários de IP, segredo e intervalo para evitar abuso, sem guardar o IP original nesses registros.

### Armazenamento e cookies

O localStorage guarda idioma (seoki-language), interface de tabelas (seoki-table-ui), painéis (seoki-table-panels) e ID, data e exclusão estatística. Não há expiração fixa; apague-os nos dados do site. Bloquear o armazenamento limita preferências salvas. Não criamos cookies próprios de login para visitantes comuns.

Só administradores recebem o cookie seguro \_\_Host-seoki-admin, por até uma hora. Provedores de hospedagem e segurança podem tratar cookies e conexões conforme suas políticas. Apagar dados locais não exclui consultas nem estatísticas do servidor.

### Provedores e links externos

A Cloudflare fornece páginas, segurança, APIs e banco de dados e pode tratar IP, horário e informações do navegador nas conexões. O Brevo processa emails de consultas e respostas. Conforme infraestrutura e configurações, esses dados podem ser tratados fora da Coreia; consulte as políticas abaixo sobre retenção e transferências. Após cinco senhas de administrador incorretas seguidas, o Cloudflare Turnstile faz a verificação humana e pode tratar IP, navegador e sinais de segurança. Os tokens são validados no servidor e não são armazenados. Falhas por IP usam um hash temporário; dez falhas geram bloqueio de 15 minutos.

Não vendemos documentos nem os fornecemos para anúncios. O compartilhamento fora dos fins descritos fica limitado a serviços e segurança necessários ou exigências legais. Lojas de apps, redes sociais e outros destinos externos têm políticas próprias.

### Anúncios e personalização

Anúncios reais estão desativados. A meta tag de verificação do AdSense e o ads.txt não carregam anúncios por si só. Antes da ativação, serão aplicados este aviso e os mecanismos de consentimento necessários.

Se forem introduzidos anúncios do Google, terceiros, incluindo o Google, poderão usar cookies publicitários com base em visitas anteriores a este ou outros sites. Google e parceiros podem usá-los para personalização. Gerencie suas escolhas nas configurações de anúncios do Google ou na página de opções do setor abaixo. O conteúdo das tabelas não é fornecido para publicidade.

### Direitos, segurança e alterações

Entre em contato para solicitar acesso, correção, exclusão, limitação ou retirada de consentimento. Podemos pedir verificação mínima, como ID de postagem ou relatório. Não publique documentos de identidade nem dados sensíveis. Omitir campos necessários pode limitar atendimento ou avisos, sem impedir a conversão de tabelas.

Usamos controle de acesso administrativo, HTTPS e hash/criptografia de senhas. Registros destinados à exclusão saem do banco; backups do provedor e cópias de email podem seguir retenção própria. Atualizaremos esta página e sua vigência quando mudarem dados, finalidades, anúncios ou fornecedores.

### Privacidade dos serviços relacionados

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

Contato de privacidade: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-zh-hans"></a>
<div lang="zh-Hans" dir="ltr">

## 简体中文 · Seoki Apps · 隐私政策

生效日期: 2026-11-07

Seoki Apps 在韩国运营 seokiapps.com。本政策适用于主页、一般网页、访问统计、客户支持和提交给网站的错误报告。表格转换器的表格及文件处理适用独立政策；其他应用的数据处理请同时查看各自政策。隐私问题和权利请求请发送至 contact@seokiapps.com。

[表格转换器 · 隐私政策](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-zh-hans)

### 访问统计与退出

普通页面和网页工具会在 localStorage 中保存随机浏览器标识符和最后统计日期，避免重复计算。各工具的日期键使用 seoki-tool-day:\<tool\>。服务器保存标识符的 SHA-256 哈希、日期和允许列表中的工具标识，计算全站及各工具的每日、每周和每月访客数。各工具合并所有界面语言的数据，刷新不会重复计数。统计 API 不保存姓名、邮箱、原始 IP、访问 URL、表格内容或屏幕图像。哈希标识符不被视为完全匿名的信息。 国家统计还会将 Cloudflare 提供的连接国家代码与标识符哈希和日期一起保存。这些统计不保存原始 IP、城市或精确位置；VPN 等可能影响国家估算。浏览器还会保存网站及各工具最后进行国家统计的日期。

哈希和计数目前没有自动到期机制。清除网站数据或启用下方排除设置会删除本地标识符。服务器记录问题请联系我们。退出统计、GPC 或 Do Not Track 会阻止后续访问计数请求。

[将此浏览器排除在访问统计之外](https://seokiapps.com/zh-Hans/privacy-settings/)

### 咨询与邮件

咨询需要应用名称、标题、正文、语言和提交时间；邮箱与帖子密码为选填。无密码时正文及回复公开；设置密码后标题和应用名仍公开，邮箱不在列表公开。密码保存为验证哈希及管理员可恢复的加密副本，请勿复用其他服务的密码。

新咨询及所填邮箱通过 Brevo 向运营者发送通知；回复邮件可能包含咨询及回复。超过 180 天的帖子和回复在新咨询提交时列入清理，并非在固定时刻删除。如需提前删除请联系。直接发送的邮件及邮件商记录可能另行保留。

### 错误报告与滥用防护

仅接收用户在应用中同意发送的报告，包含应用和系统版本、平台、设备描述、症状、日志、报告 ID 及时间，用于排错。系统遮盖已知邮箱和凭据模式，但无法保证全部识别，请发送前检查。 ZZZ Disk Reader的识别错误报告还包含用户选择的截图、识别语言、权限及模型状态、近期识别与崩溃记录。只有点击发送才通过HTTPS提交，仅管理员可查看。图片与日志在30天后一起清理。图片不会自动遮盖隐私信息，发送前请遮盖UID等不想分享的内容。 在表格转换器的问题报告中，用户主动提交的描述、网址、浏览器信息及可选的复现文件（最大 8 MB）用于排查问题和改进工具。工作区表格不会自动发送。只有管理员可以下载附件，文件中的个人信息不会自动遮盖。附件遵循与错误日志相同的保留和清理规则。

超过 30 天的日志在提交或管理员查询时清理，最多保存 1,000 份。防重复及周统计用的报告 ID、应用、内容哈希和时间单独保存，目前无自动到期。部分 API 为防滥用使用 IP、秘密值及时间段生成临时哈希，不在这些记录中保存原始 IP。

### 浏览器存储与 Cookie

localStorage 保存语言(seoki-language)、表格设置(seoki-table-ui)、面板状态(seoki-table-panels)及统计 ID、日期、退出选择。无固定有效期，可在浏览器网站数据中删除；禁用存储会影响偏好保存。本站不为普通访客建立自己的登录 Cookie。

仅管理员登录使用安全会话 Cookie \_\_Host-seoki-admin，最长一小时。托管及安全商的 Cookie 和连接记录适用其政策。清除本地数据不会删除服务器咨询或已有统计。

### 服务商与外部链接

Cloudflare 提供网页分发、安全、API 和数据库，可能处理 IP、请求时间、浏览器信息等技术数据。Brevo 处理咨询与回复邮件。数据可能因服务商基础设施及设置在韩国以外处理；保留及传输安排参阅下方政策。 管理员密码连续5次错误后，将使用 Cloudflare Turnstile 进行人机验证，Cloudflare 可能处理 IP、浏览器和安全信号。验证令牌仅在服务器校验，不予保存。各 IP 的连续失败次数使用临时哈希管理，连续10次失败后阻止登录15分钟。

我们不出售文档或将其用于广告共享。超出说明目的的共享仅限必要的服务、安全处理或法律要求。应用商店、社交媒体等外部网站适用各自政策。

### 广告与个性化选择

当前实际广告已禁用。AdSense 验证元标签和 ads.txt 自身不会加载广告。启用广告前将落实本说明和必要的同意机制。

若引入 Google 广告，包括 Google 在内的第三方可能使用广告 Cookie，根据您此前对本站及其他网站的访问投放广告。Google 及合作伙伴可能据此提供个性化广告。可通过下方 Google 广告设置或行业选择页面管理个性化。表格内容不会提供给广告。

### 您的权利、安全与变更

您可联系申请查阅、更正、删除、限制处理或撤回同意。可能需要帖子或报告 ID 等最低限度的核实信息，请勿公开身份证件或敏感信息。拒绝必要字段可能影响咨询或邮件通知，但不妨碍表格转换。

我们采用管理员访问控制、HTTPS 及密码哈希和加密。删除记录从数据库移除；服务商备份和邮件副本可能有不同保留流程。数据、目的、广告或服务商处理变化时会更新本页面和生效日期。

### 相关服务的隐私说明

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

隐私联系: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-hi"></a>
<div lang="hi" dir="ltr">

## हिन्दी · Seoki Apps · गोपनीयता नीति

लागू होने की तारीख: 2026-11-07

Seoki Apps कोरिया गणराज्य से seokiapps.com संचालित करता है। यह नीति होमपेज, सामान्य वेबपृष्ठों, विज़िटर आँकड़ों, सहायता और वेबसाइट पर भेजी गई त्रुटि रिपोर्टों पर लागू होती है। तालिका कनवर्टर में तालिकाओं और फ़ाइलों के प्रसंस्करण की अलग नीति है; अन्य ऐप की अपनी नीति भी देखें। गोपनीयता संबंधी प्रश्न और अधिकार अनुरोध contact@seokiapps.com पर भेजें।

[तालिका कन्वर्टर · गोपनीयता नीति](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-hi)

### विज़िटर आँकड़े और बाहर रहने का विकल्प

सामान्य पृष्ठ और वेब टूल दोहरी गिनती रोकने के लिए localStorage में यादृच्छिक ब्राउज़र पहचान और पिछली गिनती की तारीख रखते हैं। टूल की तारीख की कुंजियाँ seoki-tool-day:\<tool\> का उपयोग करती हैं। सर्वर पहचान का SHA-256 हैश, तारीख और अनुमत टूल पहचान रखकर पूरे साइट और हर टूल के दैनिक, साप्ताहिक और मासिक आगंतुक गिनता है। सभी इंटरफ़ेस भाषाओं की गिनती संयुक्त है और रिफ्रेश दोबारा नहीं गिना जाता। आँकड़ों की API नाम, ईमेल, मूल IP, देखे गए URL, तालिका की सामग्री या स्क्रीन चित्र नहीं रखती। हैश पहचान पूरी तरह अनाम नहीं मानी जाती। देश के आँकड़ों के लिए Cloudflare का कनेक्शन देश कोड भी पहचान के हैश और तारीख के साथ रखा जाता है। इन आँकड़ों में मूल IP, शहर या सटीक स्थान नहीं रखे जाते; VPN से देश का अनुमान बदल सकता है। ब्राउज़र साइट और टूल की देश-गणना की पिछली तारीखें भी रखता है।

हैश और गिनती अभी अपने आप समाप्त नहीं होते। साइट डेटा मिटाने या नीचे बाहर रखने का विकल्प चालू करने पर स्थानीय पहचान हटती है। सर्वर रिकॉर्ड के लिए संपर्क करें। बाहर रखने का विकल्प, GPC या Do Not Track अगली गिनती की रिक्वेस्ट रोकता है।

[इस ब्राउज़र को विज़िटर आँकड़ों से बाहर रखें](https://seokiapps.com/hi/privacy-settings/)

### सहायता और ईमेल

ऐप, विषय, संदेश, भाषा और समय आवश्यक हैं; ईमेल और पोस्ट पासवर्ड वैकल्पिक हैं। पासवर्ड न हो तो संदेश और जवाब सार्वजनिक हैं। पासवर्ड होने पर भी विषय व ऐप सार्वजनिक रहते हैं; ईमेल बोर्ड पर नहीं दिखता। पासवर्ड का सत्यापन हैश और व्यवस्थापक द्वारा वापस पाई जा सकने वाली एन्क्रिप्टेड प्रति रखी जाती है। अन्य सेवाओं का पासवर्ड दोबारा न इस्तेमाल करें।

नए संदेश और दिया गया ईमेल ऑपरेटर सूचना के लिए Brevo से गुजरते हैं; जवाब की सूचना में सवाल और जवाब शामिल हो सकते हैं। 180 दिन पुराने संदेश नए संदेश आने पर सफ़ाई के योग्य होते हैं, किसी निश्चित समय पर मिटने की गारंटी नहीं। पहले हटाने के लिए लिखें। सीधे ईमेल और प्रदाता रिकॉर्ड अलग रह सकते हैं।

### त्रुटि रिपोर्ट और दुरुपयोग रोकना

ऐप से सहमति के बाद भेजी रिपोर्ट ही ली जाती है: ऐप और OS संस्करण, प्लेटफ़ॉर्म, डिवाइस विवरण, लक्षण, लॉग, ID और समय। ज्ञात ईमेल और क्रेडेंशियल पैटर्न छिपाए जाते हैं, लेकिन सब नहीं पकड़े जाते। भेजने से पहले जाँचें। ZZZ Disk Reader की पहचान संबंधी रिपोर्ट में उपयोगकर्ता द्वारा चुना गया स्क्रीनशॉट, पहचान की भाषा, अनुमति और मॉडल की स्थिति तथा हाल की पहचान और क्रैश के रिकॉर्ड भी शामिल होते हैं। भेजें दबाने पर ही HTTPS से रिपोर्ट भेजी जाती है और केवल व्यवस्थापक उसे देख सकता है। चित्र भी लॉग के साथ 30 दिनों के बाद हटाए जाते हैं। चित्र की निजी जानकारी अपने आप नहीं छिपती; भेजने से पहले UID जैसी अनचाही जानकारी ढक दें। तालिका परिवर्तक की रिपोर्ट में उपयोगकर्ता द्वारा भेजा विवरण, URL, ब्राउज़र जानकारी और वैकल्पिक पुनरुत्पादन फ़ाइल (अधिकतम 8 MB) समस्या निदान और सुधार के लिए उपयोग की जाती है। कार्यक्षेत्र की तालिकाएँ अपने आप नहीं भेजी जातीं। केवल व्यवस्थापक संलग्न फ़ाइल डाउनलोड कर सकते हैं; निजी जानकारी अपने आप नहीं छिपाई जाती। फ़ाइलों पर त्रुटि लॉग के समान संग्रहण और सफाई नियम लागू होते हैं।

30 दिन पुराने लॉग जमा करने या व्यवस्थापक सूची खोलने पर साफ़ होते हैं; अधिकतम 1,000 रिपोर्ट रहती हैं। दोहराव रोकने और साप्ताहिक गिनती के ID, ऐप, सामग्री हैश और समय अलग रहते हैं और अपने आप समाप्त नहीं होते। कुछ API IP, गुप्त मान और समय से अस्थायी हैश बनाते हैं; उन रिकॉर्ड में मूल IP नहीं रहता।

### ब्राउज़र स्टोरेज और कुकी

localStorage में भाषा (seoki-language), तालिका UI (seoki-table-ui), पैनल (seoki-table-panels), आँकड़ा ID, तारीख और बाहर रहने का विकल्प रहता है। निश्चित समाप्ति नहीं; ब्राउज़र का साइट डेटा मिटाकर हटाएँ। स्टोरेज रोकने से पसंद सहेजना सीमित होता है। सामान्य विज़िटर के लिए साइट अपनी लॉगिन कुकी नहीं बनाती।

सिर्फ़ व्यवस्थापक को सुरक्षित \_\_Host-seoki-admin सत्र कुकी मिलती है, अधिकतम एक घंटे के लिए। होस्टिंग व सुरक्षा प्रदाता की कुकी और कनेक्शन उनकी नीतियों के अधीन हैं। स्थानीय डेटा मिटाने से सर्वर संदेश या पुराने आँकड़े नहीं मिटते।

### प्रदाता और बाहरी लिंक

Cloudflare पेज, सुरक्षा, API और डेटाबेस उपलब्ध कराता है और IP, समय व ब्राउज़र जानकारी संसाधित कर सकता है। Brevo सहायता और जवाब के ईमेल सँभालता है। प्रदाता की संरचना व सेटिंग के अनुसार डेटा कोरिया के बाहर संसाधित हो सकता है; रखरखाव और स्थानांतरण के लिए नीचे नीतियाँ देखें। व्यवस्थापक का पासवर्ड लगातार पाँच बार गलत होने पर Cloudflare Turnstile मानव सत्यापन करता है और IP, ब्राउज़र तथा सुरक्षा संकेतों को संसाधित कर सकता है। टोकन सर्वर पर जाँचे जाते हैं और सहेजे नहीं जाते। हर IP की लगातार असफलताओं के लिए अस्थायी हैश उपयोग होता है; दस असफलताओं पर 15 मिनट का अवरोध लगता है।

हम दस्तावेज़ नहीं बेचते या विज्ञापन के लिए नहीं देते। बताए उद्देश्य के बाहर साझा करना ज़रूरी सेवा, सुरक्षा या कानूनी माँग तक सीमित है। ऐप स्टोर, सोशल मीडिया और बाहरी साइटों की अपनी नीतियाँ हैं।

### विज्ञापन और निजीकरण

असली विज्ञापन अभी बंद हैं। AdSense सत्यापन मेटा टैग और ads.txt अपने आप विज्ञापन नहीं लाते। चालू करने से पहले यह सूचना और ज़रूरी सहमति प्रक्रिया लागू की जाएगी।

Google विज्ञापन आने पर Google समेत तीसरे पक्ष इस या दूसरी साइटों की पुरानी विज़िट के आधार पर विज्ञापन कुकी इस्तेमाल कर सकते हैं। Google और भागीदार इनसे वैयक्तिक विज्ञापन दे सकते हैं। नीचे Google विज्ञापन सेटिंग या उद्योग विकल्प पेज पर चुनाव बदलें। तालिका की सामग्री विज्ञापन के लिए नहीं दी जाती।

### अधिकार, सुरक्षा और बदलाव

पहुँच, सुधार, मिटाना, रोक या सहमति वापस लेने के लिए संपर्क करें। पोस्ट या रिपोर्ट ID जैसी न्यूनतम पुष्टि माँगी जा सकती है। पहचान पत्र या संवेदनशील जानकारी सार्वजनिक न डालें। आवश्यक फ़ील्ड न देने से सहायता या ईमेल रुक सकते हैं, पर तालिका रूपांतरण नहीं।

व्यवस्थापक नियंत्रण, HTTPS और पासवर्ड हैश/एन्क्रिप्शन का इस्तेमाल होता है। हटाने योग्य रिकॉर्ड डेटाबेस से हटते हैं; प्रदाता बैकअप या ईमेल प्रतियों के अलग नियम हो सकते हैं। डेटा, उद्देश्य, विज्ञापन या प्रदाता बदलने पर यह पेज और तारीख बदले जाएँगे।

### संबंधित सेवाओं की गोपनीयता जानकारी

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

गोपनीयता संपर्क: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-ar"></a>
<div lang="ar" dir="rtl">

## العربية · Seoki Apps · سياسة الخصوصية

تاريخ السريان: 2026-11-07

تدير Seoki Apps موقع seokiapps.com من جمهورية كوريا. تنطبق هذه السياسة على الصفحة الرئيسية والصفحات العامة وإحصاءات الزيارة ودعم العملاء وتقارير الأخطاء المرسلة إلى الموقع. تخضع معالجة الجداول والملفات في محوّل الجداول لسياسة مستقلة؛ راجع أيضًا سياسة كل تطبيق آخر. أرسل أسئلة الخصوصية وطلبات الحقوق إلى contact@seokiapps.com.

[محوّل جداول · سياسة الخصوصية](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-ar)

### الإحصاءات والاستبعاد

تخزن الصفحات العادية وأدوات الويب معرّف متصفح عشوائيًا وتاريخ آخر احتساب في localStorage لمنع التكرار. تستخدم مفاتيح التاريخ لكل أداة seoki-tool-day:\<tool\>. يخزن الخادم تجزئة SHA-256 للمعرّف والتاريخ ومعرّف أداة من قائمة مسموحة لحساب الزوار يوميًا وأسبوعيًا وشهريًا للموقع ولكل أداة. تجمع إحصاءات الأداة جميع لغات الواجهة ولا يُحسب التحديث مرتين. لا تخزن واجهة الإحصاءات أسماء أو بريدًا إلكترونيًا أو عناوين IP خامًا أو روابط الصفحات أو محتوى الجداول أو صور الشاشة. لا تُعد المعرّفات المجزأة مجهولة تمامًا. تحفظ إحصاءات البلد أيضًا رمز بلد الاتصال الذي توفره Cloudflare مع تجزئة المعرّف والتاريخ. لا تُحفظ عناوين IP الخام أو المدن أو المواقع الدقيقة في هذه الإحصاءات؛ وقد تؤثر الشبكات الخاصة الافتراضية على تقدير البلد. يخزن المتصفح أيضًا تواريخ آخر احتساب للبلد للموقع والأدوات.

لا توجد حاليًا مدة انتهاء تلقائية للتجزئات والأعداد. حذف بيانات الموقع أو تفعيل الاستبعاد أدناه يزيل المعرّف المحلي. تواصل بشأن سجلات الخادم. يمنع الاستبعاد أو GPC أو Do Not Track طلبات الاحتساب اللاحقة.

[استبعاد هذا المتصفح من إحصاءات الزيارات](https://seokiapps.com/ar/privacy-settings/)

### الدعم والبريد

يتطلب الدعم اسم التطبيق والموضوع والرسالة واللغة والوقت؛ البريد وكلمة مرور المنشور اختياريان. دون كلمة مرور تكون الرسالة والردود عامة. يظل الموضوع والتطبيق عامين حتى مع الحماية، ولا يظهر البريد. تُحفظ كلمة المرور كتجزئة للتحقق ونسخة مشفرة يستطيع المسؤول استعادتها؛ لا تعِد استخدام كلمات مرور أخرى.

تمر الاستفسارات والبريد المقدم عبر Brevo لإشعار المشغّل، وقد تتضمن رسائل الرد الاستفسار والجواب. تُنظف المنشورات الأقدم من 180 يومًا عند استلام استفسار جديد، وليس في وقت حذف محدد. اطلب الحذف المبكر بالتواصل. قد تبقى رسائل البريد المباشرة وسجلات المزود منفصلة.

### تقارير الأخطاء ومنع الإساءة

نستلم تقارير التطبيقات بعد موافقة المستخدم فقط: إصدار التطبيق والنظام والمنصة ووصف الجهاز والأعراض والسجل والمعرّف والوقت. تُحجب أنماط البريد وبيانات الاعتماد المعروفة، لكن الكشف غير شامل؛ راجع قبل الإرسال. تتضمن بلاغات التعرّف في ZZZ Disk Reader أيضًا لقطة الشاشة التي يختارها المستخدم ولغة التعرّف وحالة الأذونات والنماذج وسجلات التعرّف والتعطل الأخيرة. لا تُرسل عبر HTTPS إلا بعد الضغط على إرسال، ولا يطّلع عليها إلا المسؤول. تُحذف الصور مع السجلات بعد 30 يومًا. لا تُحجب المعلومات في الصور تلقائيًا؛ غطِّ ما لا تريد مشاركته، مثل UID، قبل الإرسال. في بلاغات محول الجداول، يرسل المستخدم الوصف والرابط ومعلومات المتصفح وملفًا اختياريًا لإعادة المشكلة حتى 8 MB للتشخيص والتحسين. لا تُرسل جداول مساحة العمل تلقائيًا. يمكن للمسؤولين فقط تنزيل المرفقات، ولا تُحجب بياناتها الشخصية تلقائيًا. تخضع المرفقات لقواعد الاحتفاظ والتنظيف نفسها الخاصة بسجلات الأخطاء.

تُنظف السجلات الأقدم من 30 يومًا عند الإرسال أو عرض المسؤول، بحد 1,000 تقرير. يُحفظ المعرّف والتطبيق وتجزئة المحتوى والوقت منفصلة لمنع التكرار والإحصاء الأسبوعي دون انتهاء تلقائي. تستخدم بعض الواجهات تجزئات مؤقتة من IP وسر وفترة زمنية لمنع الإساءة، دون حفظ IP الأصلي في تلك السجلات.

### تخزين المتصفح وملفات الارتباط

يحفظ localStorage اللغة (seoki-language) وواجهة الجدول (seoki-table-ui) واللوحات (seoki-table-panels) ومعرّف الإحصاءات وتاريخها والاستبعاد. لا انتهاء ثابت لها؛ احذفها من بيانات الموقع. منع التخزين يحد من حفظ التفضيلات. لا ننشئ ملف ارتباط لتسجيل دخول الزائر العادي.

يستخدم المسؤول فقط ملف الجلسة الآمن \_\_Host-seoki-admin لمدة ساعة كحد أقصى. تخضع ملفات واتصالات مزودي الاستضافة والأمان لسياساتهم. حذف البيانات المحلية لا يمحو الاستفسارات أو الإحصاءات السابقة من الخادم.

### المزودون والروابط الخارجية

توفر Cloudflare الصفحات والأمان والواجهات وقاعدة البيانات، وقد تعالج IP ووقت الطلب ومعلومات المتصفح. تتولى Brevo بريد الاستفسارات والردود. قد تُعالج البيانات خارج كوريا وفق البنية والإعدادات؛ راجع سياسات الاحتفاظ والنقل أدناه. بعد خمس كلمات مرور مسؤول خاطئة متتالية، يُجري Cloudflare Turnstile تحققًا بشريًا وقد يعالج عنوان IP والمتصفح وإشارات الأمان. تُتحقق الرموز في الخادم ولا تُحفظ. تُستخدم تجزئة مؤقتة لتتبع الإخفاقات لكل IP؛ وتؤدي عشرة إخفاقات إلى حظر لمدة 15 دقيقة.

لا نبيع المستندات ولا نوفرها للإعلانات. المشاركة خارج الأغراض المبينة تقتصر على الخدمات والأمان الضروريين أو المتطلبات القانونية. لمتاجر التطبيقات والشبكات الاجتماعية والمواقع الخارجية سياساتها الخاصة.

### الإعلانات والتخصيص

الإعلانات الفعلية معطلة حاليًا. لا تحمّل علامة تحقق AdSense وads.txt إعلانات بذاتهما. ستُطبق هذه المعلومات وترتيبات الموافقة اللازمة قبل التفعيل.

إذا أُدخلت إعلانات Google، فقد تستخدم جهات خارجية بما فيها Google ملفات ارتباط إعلانية بناءً على زيارات سابقة لهذا الموقع أو غيره. قد تستخدمها Google وشركاؤها لتخصيص الإعلانات. أدر اختياراتك من إعدادات Google أو صفحة خيارات القطاع أدناه. لا يُقدم محتوى الجداول للإعلانات.

### الحقوق والحماية والتغييرات

تواصل لطلب الوصول أو التصحيح أو الحذف أو التقييد أو سحب الموافقة. قد نطلب تحققًا محدودًا كمعرّف المنشور أو التقرير. لا تنشر وثائق الهوية أو معلومات حساسة. قد يؤدي ترك الحقول اللازمة إلى تعطيل الدعم أو إشعارات البريد دون منع تحويل الجداول.

نستخدم ضوابط وصول المسؤول وHTTPS وتجزئة وتشفير كلمات المرور. تُزال سجلات الحذف من قاعدة البيانات؛ وقد تتبع النسخ الاحتياطية والبريد لدى المزود إجراءات مختلفة. سنحدّث الصفحة وتاريخها عند تغير البيانات أو الأغراض أو الإعلانات أو معالجة المزودين.

### خصوصية الخدمات المرتبطة

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

جهة اتصال الخصوصية: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-fr"></a>
<div lang="fr" dir="ltr">

## Français · Seoki Apps · Politique de confidentialité

Date d’effet: 2026-11-07

Seoki Apps exploite seokiapps.com depuis la République de Corée. Cette politique couvre l’accueil, les pages générales, les statistiques de visite, le support et les rapports d’erreur envoyés au site. Le traitement des tableaux et fichiers du Convertisseur de tableaux relève d’une politique distincte ; consultez aussi celle de chaque autre application. Adressez vos questions et demandes relatives à la confidentialité à contact@seokiapps.com.

[Convertisseur de tableaux · Politique de confidentialité](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-fr)

### Statistiques et exclusion

Les pages classiques et les outils web enregistrent un identifiant aléatoire du navigateur et la dernière date comptée dans localStorage pour éviter les doublons. Les clés de date par outil utilisent seoki-tool-day:\<tool\>. Le serveur conserve le hachage SHA-256 de cet identifiant, la date et un identifiant d’outil autorisé pour calculer les visiteurs quotidiens, hebdomadaires et mensuels du site et de chaque outil. Les langues sont regroupées et les actualisations ne sont pas comptées deux fois. L’API de statistiques ne conserve ni noms, ni e-mails, ni IP brutes, ni URL visitées, ni contenu des tableaux, ni images d’écran. Les identifiants hachés ne sont pas considérés comme totalement anonymes. Les statistiques par pays conservent aussi le code du pays de connexion fourni par Cloudflare avec le hachage et la date. Elles ne conservent ni IP brutes, ni villes, ni positions précises ; un VPN peut modifier l’estimation. Le navigateur conserve également les dernières dates de comptage par pays du site et des outils.

Les empreintes et décomptes n’ont actuellement aucune expiration automatique. Effacer les données du site ou activer l’exclusion supprime l’identifiant local. Contactez-nous pour les enregistrements du serveur. L’exclusion, GPC ou Do Not Track empêche les demandes de comptage suivantes.

[Exclure ce navigateur des statistiques](https://seokiapps.com/fr/privacy-settings/)

### Assistance et email

L’assistance exige application, objet, message, langue et date ; email et mot de passe du message sont facultatifs. Sans mot de passe, messages et réponses sont publics. Objet et application restent publics même avec protection ; l’email n’est pas affiché. Les mots de passe sont conservés sous forme d’empreinte de vérification et de copie chiffrée récupérable par l’administrateur. Ne réutilisez pas d’autres mots de passe.

Les demandes et emails fournis passent par Brevo pour avertir l’opérateur ; les notifications de réponse peuvent inclure demande et réponse. Les données de plus de 180 jours sont nettoyées lors de nouvelles demandes, sans suppression à heure fixe. Contactez-nous pour une suppression anticipée. Les emails directs et traces du prestataire peuvent subsister séparément.

### Rapports d’erreurs et abus

Les rapports provenant des applications sont reçus après consentement : versions de l’application et du système, plateforme, appareil, symptômes, journaux, ID et date. Les motifs connus d’emails et d’identifiants secrets sont masqués, sans détection exhaustive. Vérifiez avant l’envoi. Les signalements de reconnaissance de ZZZ Disk Reader comprennent aussi la capture choisie, la langue de reconnaissance, l’état des autorisations et modèles et les traces récentes de reconnaissance et de plantage. Ils sont envoyés par HTTPS uniquement après appui sur Envoyer et seul l’administrateur peut les consulter. Les images sont supprimées avec les journaux après 30 jours. Elles ne sont pas masquées automatiquement ; cachez les détails tels que votre UID avant l’envoi. Pour les signalements du convertisseur de tableaux, l’utilisateur envoie une description, une URL, des informations du navigateur et un fichier facultatif de reproduction de 8 Mo maximum pour le diagnostic et l’amélioration. Les tableaux de travail ne sont pas envoyés automatiquement. Seuls les administrateurs peuvent télécharger les pièces jointes ; leurs données personnelles ne sont pas masquées automatiquement. Les mêmes règles de conservation et de nettoyage que pour les journaux s’appliquent.

Les journaux de plus de 30 jours sont nettoyés lors des envois ou consultations administratives, avec 1 000 rapports au maximum. ID, application, empreinte du contenu et date restent séparément pour les doublons et comptes hebdomadaires, sans expiration automatique. Certaines API utilisent une empreinte temporaire d’IP, secret et période pour prévenir les abus, sans conserver l’IP brute dans ces traces.

### Stockage et cookies

localStorage conserve langue (seoki-language), interface des tableaux (seoki-table-ui), panneaux (seoki-table-panels), ID, date et exclusion statistique. Sans expiration fixe, ils peuvent être supprimés via les données du site. Bloquer le stockage limite les préférences. Aucun cookie de connexion propre au site n’est créé pour les visiteurs ordinaires.

Seuls les administrateurs reçoivent le cookie sécurisé \_\_Host-seoki-admin, pour une heure au plus. Les cookies et connexions des prestataires suivent aussi leurs politiques. Effacer les données locales ne supprime pas les demandes ni les statistiques du serveur.

### Prestataires et liens externes

Cloudflare fournit diffusion des pages, sécurité, API et base de données, et peut traiter IP, heure et informations du navigateur. Brevo gère les emails de demandes et réponses. Selon les infrastructures et réglages, les données peuvent être traitées hors de Corée ; les politiques ci-dessous détaillent conservation et transferts. Après cinq mots de passe administrateur incorrects consécutifs, Cloudflare Turnstile effectue une vérification humaine et peut traiter l’IP, le navigateur et des signaux de sécurité. Les jetons sont vérifiés côté serveur sans être conservés. Les échecs par IP sont associés à un hachage temporaire ; dix échecs déclenchent un blocage de 15 minutes.

Nous ne vendons pas les documents ni ne les transmettons à des fins publicitaires. Le partage hors des finalités décrites se limite aux services et à la sécurité nécessaires ou aux obligations légales. Boutiques d’applications, réseaux sociaux et sites externes ont leurs propres politiques.

### Publicité et personnalisation

La publicité réelle est désactivée. La balise de vérification AdSense et ads.txt ne chargent pas de publicité par eux-mêmes. Cette information et les mécanismes de consentement nécessaires seront appliqués avant toute activation.

Si la publicité Google est introduite, des tiers dont Google pourront utiliser des cookies publicitaires fondés sur les visites antérieures de ce site ou d’autres sites. Google et ses partenaires peuvent les utiliser pour personnaliser les annonces. Gérez vos choix via les paramètres Google ou la page de choix du secteur ci-dessous. Le contenu des tableaux n’est pas fourni pour la publicité.

### Droits, protection et changements

Contactez-nous pour accès, rectification, effacement, limitation ou retrait du consentement. Une vérification minimale, telle qu’un ID de message ou de rapport, peut être demandée. Ne publiez pas de pièce d’identité ni de donnée sensible. Omettre les champs nécessaires peut limiter l’assistance ou les notifications, mais pas la conversion des tableaux.

Nous utilisons contrôles d’accès administratifs, HTTPS et empreintes/chiffrement des mots de passe. Les données à effacer sont retirées de la base ; les sauvegardes et copies d’emails peuvent suivre des procédures distinctes. Cette page et sa date seront mises à jour si données, finalités, publicité ou prestataires changent.

### Confidentialité des services associés

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

Contact confidentialité: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-ja"></a>
<div lang="ja" dir="ltr">

## 日本語 · Seoki Apps · プライバシーポリシー

施行日: 2026-11-07

Seoki Appsは大韓民国でseokiapps.comを運営しています。本方針はホームページ、一般のウェブページ、訪問統計、お問い合わせ、サイトに送信されたエラー報告に適用されます。表変換ツールの表・ファイル処理には別の方針が適用されます。他のアプリの処理は各アプリの方針もご確認ください。プライバシーの質問や権利に関する請求はcontact@seokiapps.comへお送りください。

[表変換ツール · プライバシーポリシー](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-ja)

### アクセス統計と除外

通常ページとウェブツールでは重複集計を避けるため、ランダムなブラウザー識別子と最終集計日を localStorage に保存します。ツール別の日付キーには seoki-tool-day:\<tool\> を使います。サーバーには識別子の SHA-256 ハッシュ、日付、許可されたツール識別子を保存し、サイト全体とツール別の日・週・月の訪問者数を計算します。各ツールは全表示言語を合算し、再読み込みは重複集計しません。統計 API は氏名、メール、元の IP、訪問 URL、表の内容、画面画像を保存しません。ハッシュ識別子は完全な匿名情報とは見なしません。 国別の統計にはCloudflareが提供する接続国コードも識別子のハッシュと日付とともに保存します。この統計に元のIP、都市、正確な位置は保存しません。VPNなどにより国の推定が実際の位置と異なる場合があります。サイト全体とツール別の国集計日もブラウザーに保存します。

ハッシュと集計値には現在、自動失効がありません。サイトデータ削除や下の除外設定でローカル識別子を削除できます。サーバー記録はご相談ください。除外、GPC、Do Not Trackは以後の集計要求を防ぎます。

[このブラウザーをアクセス統計から除外](https://seokiapps.com/ja/privacy-settings/)

### お問い合わせとメール

アプリ名・件名・本文・言語・日時が必要で、メールと投稿パスワードは任意です。パスワードなしでは本文と回答も公開され、設定した場合も件名とアプリ名は公開されます。メールは掲示板に表示しません。パスワードは検証用ハッシュと管理者が復元できる暗号化コピーで保存するため、他サービスのものを使い回さないでください。

新規のお問い合わせ内容と入力メールはBrevoを介して運営者へ通知され、回答メールにも問い合わせと回答が含まれる場合があります。180日を過ぎた投稿・回答は新規受付時に整理対象となり、時刻指定の削除ではありません。早期削除はご連絡ください。直接のメールや提供者の記録は別に残る場合があります。

### エラー報告と不正防止

アプリで送信に同意した報告のみ受け付けます。アプリ・OSの版、プラットフォーム、端末説明、症状、ログ、報告ID、日時を改善に使います。既知のメール・認証情報のパターンを隠しますが完全ではないため、送信前にご確認ください。 ZZZ Disk Readerの認識エラー報告には、利用者が選んだ画面画像、認識言語、権限・モデルの状態、最近の認識・異常終了記録も含まれます。送信を押した場合のみHTTPSで受信し、管理者だけが閲覧できます。画像もログとともに30日後に削除します。画像の個人情報は自動で隠されません。送信前にUIDなど共有したくない情報を隠してください。 表変換ツールの問題報告では、利用者が送信した説明・URL・ブラウザー情報と任意の再現用ファイル（最大8 MB）を問題解決と改善に使用します。作業中の表は自動送信しません。添付は管理者だけがダウンロードでき、ファイル内の個人情報は自動で隠しません。添付にもエラーログと同じ保存・整理基準を適用します。

30日を過ぎたログを受付・管理者一覧表示時に整理し、最大1,000件に制限します。重複防止・週次集計用のID・アプリ・内容ハッシュ・日時は別保存で自動失効がありません。一部APIはIP・秘密値・時間帯から一時ハッシュを作り、不正防止記録には元のIPを保存しません。

### ブラウザー保存とCookie

localStorageには言語(seoki-language)、表UI(seoki-table-ui)、パネル(seoki-table-panels)、統計ID・日付・除外設定を保存します。固定期限はなく、サイトデータから削除できます。保存を禁止すると設定維持が制限されます。一般訪問者に独自のログインCookieは作りません。

管理者のみ安全なセッションCookie \_\_Host-seoki-adminを最大1時間使います。ホスティング・セキュリティ提供者のCookieや接続記録には各社方針も適用されます。ローカル削除でサーバーの問い合わせや過去の統計は消えません。

### 提供者と外部リンク

Cloudflareは配信・安全対策・API・データベースを提供し、IP・要求日時・ブラウザー情報を処理する場合があります。Brevoは問い合わせ・回答メールを処理します。各社の設備・設定により韓国外で処理される場合があり、保存・移転は下の案内をご確認ください。 管理者パスワードを5回連続で間違えるとCloudflare Turnstileで人間確認を行い、CloudflareがIP、ブラウザー、安全確認用の情報を処理する場合があります。トークンはサーバーで検証し、保存しません。IP別の連続失敗回数は一時的なハッシュで管理し、10回失敗すると15分間ブロックします。

文書の販売や広告目的の提供はしません。目的外の共有は必要な運営・安全処理や法令上の要求に限ります。アプリストアやSNSなど外部サイトには各サイトの方針が適用されます。

### 広告とパーソナライズ

実広告は現在無効です。AdSense認証メタタグとads.txtだけで広告を読み込むことはありません。広告を有効にする前に本案内と必要な同意手続きを適用します。

Google広告を導入すると、Googleを含む第三者が当サイトや他サイトへの過去の訪問に基づき広告Cookieを使用できます。Googleとパートナーはパーソナライズ広告に使う場合があります。下のGoogle広告設定や業界の選択ページから管理できます。表の内容は広告に提供しません。

### 権利、安全対策と変更

開示・訂正・削除・処理制限・同意撤回はご連絡ください。投稿・報告IDなど最小限の確認をお願いする場合があります。身分証や機微情報を公開しないでください。必要情報を省くと問い合わせやメール通知が使えない場合がありますが、表変換は利用できます。

管理者アクセス制御、HTTPS、パスワードのハッシュ・暗号化を使用します。削除対象をデータベースから除去しますが、提供者のバックアップやメールには別の保存手順が適用される場合があります。項目・目的・広告・提供者の処理が変われば本ページと施行日を更新します。

### 関連サービスのプライバシー案内

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

個人情報に関する連絡先: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>

<a name="privacy-id"></a>
<div lang="id" dir="ltr">

## Bahasa Indonesia · Seoki Apps · Kebijakan privasi

Tanggal berlaku: 2026-11-07

Seoki Apps mengoperasikan seokiapps.com dari Republik Korea. Kebijakan ini mencakup beranda, halaman umum, statistik kunjungan, dukungan, dan laporan kesalahan yang dikirim ke situs. Pemrosesan tabel dan berkas pada Konverter Tabel memiliki kebijakan terpisah; lihat juga kebijakan masing-masing aplikasi lain. Kirim pertanyaan dan permintaan hak privasi ke contact@seokiapps.com.

[Konverter tabel · Kebijakan privasi](https://github.com/Seoki0903-forest/resocat-privacy/blob/main/table-converter-privacy-policy.md#privacy-id)

### Statistik dan pengecualian

Halaman umum dan alat web menyimpan ID browser acak dan tanggal terakhir dihitung di localStorage untuk mencegah duplikasi. Kunci tanggal per alat menggunakan seoki-tool-day:\<tool\>. Server menyimpan hash SHA-256 ID, tanggal, dan pengenal alat yang diizinkan untuk menghitung pengunjung harian, mingguan, dan bulanan situs serta setiap alat. Semua bahasa antarmuka digabungkan dan memuat ulang tidak dihitung dua kali. API statistik tidak menyimpan nama, email, IP mentah, URL yang dikunjungi, isi tabel, atau gambar layar. Pengenal yang di-hash tidak dianggap sepenuhnya anonim. Statistik negara juga menyimpan kode negara koneksi dari Cloudflare bersama hash pengenal dan tanggal. IP mentah, kota, dan lokasi tepat tidak disimpan dalam statistik ini; VPN dapat memengaruhi perkiraan negara. Browser juga menyimpan tanggal terakhir penghitungan negara untuk situs dan alat.

Hash dan hitungan belum memiliki kedaluwarsa otomatis. Hapus data situs atau aktifkan pengecualian untuk menghapus identitas lokal. Hubungi kami tentang catatan server. Pengecualian, GPC, atau Do Not Track mencegah permintaan hitungan berikutnya.

[Kecualikan browser ini dari statistik pengunjung](https://seokiapps.com/id/privacy-settings/)

### Dukungan dan email

Dukungan memerlukan aplikasi, judul, pesan, bahasa, dan waktu; email dan kata sandi kiriman bersifat opsional. Tanpa kata sandi, pesan dan balasan bersifat publik. Judul dan aplikasi tetap publik meski terlindungi; email tidak ditampilkan. Kata sandi disimpan sebagai hash verifikasi serta salinan terenkripsi yang dapat dipulihkan administrator. Jangan gunakan ulang kata sandi layanan lain.

Pesan baru dan email yang diberikan melewati Brevo untuk pemberitahuan operator; email balasan dapat menyertakan pertanyaan dan jawaban. Kiriman lebih dari 180 hari menjadi sasaran pembersihan saat ada kiriman baru, bukan penghapusan pada jam tertentu. Hubungi kami untuk penghapusan lebih awal. Email langsung dan catatan penyedia dapat tersimpan terpisah.

### Laporan kesalahan dan penyalahgunaan

Kami menerima laporan dari aplikasi hanya setelah persetujuan: versi aplikasi dan OS, platform, deskripsi perangkat, gejala, log, ID, dan waktu. Pola email dan kredensial yang dikenal disamarkan, tetapi tidak semuanya terdeteksi; periksa sebelum mengirim. Laporan pengenalan ZZZ Disk Reader juga menyertakan tangkapan layar pilihan pengguna, bahasa pengenalan, status izin/model, dan catatan pengenalan/kerusakan terbaru. Laporan hanya dikirim melalui HTTPS setelah menekan Kirim dan hanya dapat dilihat administrator. Gambar dihapus bersama log setelah 30 hari. Informasi pada gambar tidak disamarkan otomatis; tutupi detail seperti UID sebelum mengirim. Dalam laporan Konverter tabel, pengguna mengirim deskripsi, URL, informasi peramban dan berkas reproduksi opsional hingga 8 MB untuk diagnosis dan perbaikan. Tabel ruang kerja tidak dikirim otomatis. Hanya administrator dapat mengunduh lampiran; data pribadinya tidak disamarkan otomatis. Lampiran mengikuti aturan penyimpanan dan pembersihan yang sama dengan log kesalahan.

Log lebih dari 30 hari dibersihkan saat penerimaan atau daftar administrator, maksimum 1.000 laporan. ID, aplikasi, hash isi, dan waktu untuk mencegah duplikasi serta hitungan mingguan disimpan terpisah tanpa kedaluwarsa otomatis. Beberapa API memakai hash sementara dari IP, rahasia, dan rentang waktu untuk mencegah penyalahgunaan, tanpa menyimpan IP asli di catatan tersebut.

### Penyimpanan dan cookie

localStorage menyimpan bahasa (seoki-language), UI tabel (seoki-table-ui), panel (seoki-table-panels), serta ID, tanggal, dan pengecualian statistik. Tidak ada masa berlaku tetap; hapus melalui data situs browser. Memblokirnya membatasi preferensi tersimpan. Kami tidak membuat cookie login sendiri bagi pengunjung biasa.

Hanya administrator mendapat cookie sesi aman \_\_Host-seoki-admin hingga satu jam. Cookie dan koneksi penyedia hosting atau keamanan mengikuti kebijakan mereka. Menghapus data lokal tidak menghapus pesan atau statistik server.

### Penyedia dan tautan eksternal

Cloudflare menyediakan halaman, keamanan, API, dan database, serta dapat memproses IP, waktu permintaan, dan informasi browser. Brevo menangani email dukungan dan balasan. Data dapat diproses di luar Korea sesuai infrastruktur dan pengaturan penyedia; baca kebijakan penyimpanan dan transfer pada tautan di bawah. Setelah lima kata sandi administrator salah berturut-turut, Cloudflare Turnstile melakukan verifikasi manusia dan dapat memproses IP, browser, serta sinyal keamanan. Token diverifikasi di server dan tidak disimpan. Kegagalan per IP memakai hash sementara; sepuluh kegagalan memicu blokir 15 menit.

Kami tidak menjual dokumen atau membagikannya untuk iklan. Pemrosesan di luar tujuan dijelaskan dibatasi pada layanan dan keamanan yang diperlukan atau kewajiban hukum. Toko aplikasi, media sosial, dan tujuan eksternal mempunyai kebijakan sendiri.

### Iklan dan personalisasi

Iklan nyata saat ini dinonaktifkan. Meta verifikasi AdSense dan ads.txt tidak memuat iklan dengan sendirinya. Pemberitahuan ini dan mekanisme persetujuan yang diperlukan akan diterapkan sebelum iklan aktif.

Jika iklan Google diperkenalkan, pihak ketiga termasuk Google dapat memakai cookie iklan berdasarkan kunjungan sebelumnya ke situs ini atau situs lain. Google dan mitra dapat menggunakannya untuk personalisasi. Atur melalui pengaturan iklan Google atau halaman pilihan industri di bawah. Isi tabel tidak diberikan untuk iklan.

### Hak, perlindungan, dan perubahan

Hubungi kami untuk akses, koreksi, penghapusan, pembatasan, atau pencabutan persetujuan. Kami dapat meminta verifikasi minimal seperti ID kiriman atau laporan. Jangan publikasikan identitas atau informasi sensitif. Tidak mengisi data wajib dapat membatasi dukungan atau notifikasi, tetapi konverter tetap dapat dipakai.

Kami memakai pembatasan akses administrator, HTTPS, dan hash/enkripsi kata sandi. Catatan yang dihapus dikeluarkan dari database; cadangan penyedia dan salinan email dapat mengikuti prosedur berbeda. Halaman dan tanggal akan diperbarui jika data, tujuan, iklan, atau pemrosesan penyedia berubah.

### Privasi layanan terkait

- [Cloudflare](https://www.cloudflare.com/privacypolicy/)
- [Brevo](https://www.brevo.com/legal/privacypolicy/)
- [Google](https://policies.google.com/technologies/ads)
- [Google My Ad Center](https://myadcenter.google.com/)
- [AdChoices](https://optout.aboutads.info/)
- [GitHub](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement)

Kontak privasi: [contact@seokiapps.com](mailto:contact@seokiapps.com)

</div>
