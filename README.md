# IdleClicker

Stručný popis: 
IdleClicker je jednoduchá klikací hra (incrementer) vytvořená v prostředí Windows Forms (C#). Hráč získává body klikáním na herní prvky, nakupuje vylepšení a sleduje, jak jeho skóre roste v čase. Projekt slouží jako ukázka práce s UI komponentami, událostmi a správou zdrojů v .NET.

## Klíčové funkce
* Intuitivní uživatelské rozhraní založené na Windows Forms.
* Mechanika klikání pro generování měny.
* Možnost nákupu vylepšení pro automatizaci příjmu.
* Vlastní grafické prvky a kurzory.

## Požadavky na prostředí
Pro vývoj nebo úpravu zdrojového kódu budete potřebovat:
* **Visual Studio 2022** (verze Community nebo vyšší).
* **.NET Desktop Development** workload (součást instalace Visual Studia).
* **C# 10.0+** a cílový framework **.NET 6.0 / 7.0 / 8.0** (podle nastavení vašeho projektu).

## Návod na spuštění na novém zařízení
Pokud chcete spustit již vyexportovanou aplikaci (`.exe`) na čistém počítači, postupujte následovně:

### 1. Instalace závislostí
Vyexportovaný soubor vyžaduje ke spuštění běhové prostředí .NET. Pokud není na zařízení nainstalováno, aplikace se nespustí.
* Stáhněte a nainstalujte **.NET Desktop Runtime** (odpovídající verzi vašeho projektu, např. .NET 6.0 nebo novější) z [oficiálních stránek Microsoftu](https://dotnet.microsoft.com/download/dotnet).

### 2. Spuštění aplikace
1. Stáhněte si archiv s vydanou verzí aplikace (Release).
2. Rozbalte všechny soubory do jedné složky (důležité: `.exe` soubor musí zůstat ve stejné složce se všemi doprovodnými `.dll` soubory a složkou `Resources`, pokud nejsou přibaleny přímo v exe).
3. Spusťte soubor `IdleClicker.exe`.

---
