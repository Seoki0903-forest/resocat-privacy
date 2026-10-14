[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · **ไทย** · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

ตั้งค่าความละเอียดหน้าจอแยกสำหรับแต่ละแอป Android

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## ดาวน์โหลด

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.2**

เครื่องมือฟรีสำหรับตั้งค่าสิทธิ์เริ่มต้นของ ResoCat บนโทรศัพท์หรือแท็บเล็ต Android ที่เชื่อมต่อกับพีซี Windows ผ่าน USB ต้องใช้ Windows 10/11 แบบ 64 บิต และ .NET Framework 4.5 ขึ้นไป มี ADB รวมอยู่ใน EXE แล้ว ไม่ต้องติดตั้งเพิ่มหรือแตกไฟล์ หน้าจอโปรแกรมเป็นภาษาอังกฤษบน Windows ทุกระบบ คู่มือนี้มีครบทั้ง 13 ภาษาที่ ResoCat รองรับ

[SHA-256](downloads/SHA256SUMS.txt) · [ซอร์สโค้ด](usb-helper/source/ResoCatAdbHelper.cs)

## วิธีใช้งาน

1. ติดตั้ง ResoCat จาก Google Play บนอุปกรณ์ Android
2. เปิดการแก้ไขข้อบกพร่อง USB ในตัวเลือกสำหรับนักพัฒนา โดยทั่วไปให้แตะการตั้งค่า → เกี่ยวกับโทรศัพท์ → หมายเลขบิลด์เจ็ดครั้งเพื่อเปิดตัวเลือกนี้ ชื่อเมนูอาจต่างกันตามผู้ผลิต
3. เชื่อมต่อด้วยสาย USB ที่ส่งข้อมูลได้ แล้วปลดล็อกอุปกรณ์
4. อนุญาตคอมพิวเตอร์นี้ในข้อความขออนุญาตการแก้ไขข้อบกพร่อง USB บนอุปกรณ์ อย่าเลือกอนุญาตเสมอบนพีซีที่ใช้ร่วมกัน
5. เปิด `ResoCat-ADB-Helper.exe` ที่ดาวน์โหลดจาก GitHub ทางการ
6. เลือกอุปกรณ์แล้วกด **Set permissions and open ResoCat** หากเชื่อมต่อเพียงเครื่องเดียวจะเลือกให้อัตโนมัติ
7. ตรวจสอบข้อความเสร็จสิ้น และตรวจสอบข้อกำหนดกับการตั้งค่าที่เหลือใน ResoCat ด้วยตนเอง จากนั้นถอด USB ได้

### คำอธิบายปุ่ม

- **Refresh devices** — ค้นหาอุปกรณ์หรือรีเฟรชรายการ
- **Set permissions and open ResoCat** — ตั้งค่าสิทธิ์บนอุปกรณ์ที่เลือกและเปิด ResoCat กดปุ่มนี้เพื่อเริ่มตั้งค่า
- **Save result** — บันทึกผลลัพธ์เป็นไฟล์ TXT หากต้องการความช่วยเหลือ ขั้นตอนนี้ไม่บังคับ

ปัญหาการเชื่อมต่อ: หากขึ้น `unauthorized` ให้ปลดล็อกและอนุญาตการแก้ไขข้อบกพร่อง USB แล้วกด **Refresh devices** หากขึ้น `offline` ให้เชื่อมต่อ USB ใหม่ หากไม่พบอุปกรณ์ ให้ตรวจสอบการแก้ไขข้อบกพร่อง USB สายข้อมูล และไดรเวอร์ USB ของผู้ผลิต หากเสร็จเพียงบางส่วน ให้เปิดสิทธิ์เข้าถึงข้อมูลการใช้งานในการตั้งค่า Android ตามที่ ResoCat แนะนำ เครื่องมือไม่ข้ามข้อจำกัดของผู้ผลิตหรือนโยบายอุปกรณ์ที่มีผู้ดูแล

คำเตือน Windows: โปรแกรมยังไม่มีลายเซ็นดิจิทัล จึงอาจแสดง “Windows protected your PC” ตรวจสอบ URL ดาวน์โหลดทางการและ SHA-256 แล้วเลือก “More info → Run anyway” เฉพาะไฟล์ที่คุณเชื่อถือ

สิ่งที่เปลี่ยน: ตั้งค่าเฉพาะ `WRITE_SECURE_SETTINGS` และ `GET_USAGE_STATS` ให้ ResoCat (`app.resocat.switcher`) ของผู้ใช้ Android ปัจจุบัน ไม่ต้องรูทหรือใช้สิทธิ์ผู้ดูแลพีซี ไม่เปลี่ยนความละเอียด/DPI โฆษณา การชำระเงิน หรือแบตเตอรี่ ไม่ติดตั้งแอป ลบข้อมูล หรือส่งข้อมูลไปยังเซิร์ฟเวอร์ TXT จาก **Save result** อาจมีรหัสอุปกรณ์ หากต้องการความช่วยเหลือให้ส่งไฟล์เอง หลังตั้งค่าเสร็จสามารถปิดการแก้ไขข้อบกพร่อง USB ได้

## ติดต่อ

[เว็บไซต์](https://seokiapps.com/) · [ติดต่อเรา](https://seokiapps.com/en/support/)
