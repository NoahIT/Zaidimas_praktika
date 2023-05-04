# 👾 KIN Game's

### Turinys

- [Komanda](https://github.com/NoahIT/Zaidimas_praktika#-komanda)
- [Komandos narių indėlis](https://github.com/NoahIT/Zaidimas_praktika#komandos-nari%C5%B3-ind%C4%97lis)
- [Kokias technologijas naudojome ?](https://github.com/NoahIT/Zaidimas_praktika#%EF%B8%8F-kokias-technologijas-naudojome)
- [Apie žaidima](https://github.com/NoahIT/Zaidimas_praktika#-apie-%C5%BEaidima)
- [Funkcijos](https://github.com/NoahIT/Zaidimas_praktika#-funkcijos)
- [Atsisiuntimas](https://github.com/NoahIT/Zaidimas_praktika#-atsisiuntimas)
- [Likulios detalės](https://github.com/NoahIT/Zaidimas_praktika#-likulios-detal%C4%97s)

## 👩‍💻 Komanda

 - Nojus Raščius
 - Ivan Savochkin
 - Kristupas Viščiūna

####  Komandos narių indėlis

| Studentas | Procentinė dalis | Kontekstas |
| :- | :- | :- |
| `Nojus Raščius` | `30%` | `Programavo Front-end dalį šio projekto, maketavo grafines programos dalis` |
| `Ivan Savochkin` | `40%` | `Programavo Back-end dalį šio projekto, maketavo grafines programos dalis` |
| `Kristupas Viščiūna` | `30%` | `Programavo Back/Front-end dalis, maketavo grafines programos dalis` |

## ⚡️ Kokias technologijas naudojome

| Technologija | Pavadinimas     |
| :-------- | :------- |
| `IDE` | `Visual Studio 2023` |
| `Programavimo kalba` | `C#` |
| `Forma` | `WPF app` |
| `Framework'as` | `.NET` |

## 🔦 Idėjos šankys

- Žaidimą sukūrėme įkvėpti "Pokemon Stadium" strateginio žaidimo, pazyzdys: ![d](https://www.serebii.net/stadium/battlenow.jpg)

## 🧩 Funkcijos ir kaip viskas veikia

Paleidus programą, pirmą ekraną kurį matysite tai yra `MENU`, kur yra galimos dvi funkcijos: `START` t.y. pradėti žaidimą arba `QUIT` funkcija kuri leidžia iškarto pasitraukti iš žaidimo tam prireikus. ![1](https://user-images.githubusercontent.com/78691849/236304452-ecbc19bc-ec0f-4859-9824-29d1fcc50b8a.png)

Toliau paspausdami `START` mygtuka galime judėti toliau. Išlis naujas langas kuriame turime pasirinkti ar jau žaidėme šį žaidimą ir ar esame jau kažkokį progresą padarę, tai mygtukas `LOAD LAST GAME` mums tuo ir pagelbės, tačiau jei nežaidėme ir esame naujas žaidėjas tuo tarpu spaudžiame `STRART NEW GAME`. ![2](https://user-images.githubusercontent.com/78691849/236305709-c90c3ecb-5e57-4ffa-98fc-3f0e4501c129.png)

Paspaudę `LOAD LAST GAME` arba `START NEW GAME` mygtukus pamatysime naują langą, kuris yra `CHOOSE YOUR HERO`. Čia paprasčiausiai žaidėjas pasirenka norimą "hero" su kuriuo ir keliaus/žais visą žaidimo laikotarpį. Taip pat svarbu atkreipt dėmesį jog individualus "hero" turi skirtingas kvalifikacijas (t.y. `STATS`). ![3](https://user-images.githubusercontent.com/78691849/236306690-d601f012-4a33-4519-ae51-e6f003e99170.png)


Žaidėjas pasirinkęs savo "hero" patenka į `GAME LOBBY` iš kurio gali atsirast visur kitur, kaip: `INVENTORY`, `SHOP` ir t.t. Čia apariniame dešiniająme kampe matome lentelę su visom žaidėjo kvalifikacijom. Skaičiai ekrane demonstruoja lygius, na o mygtukai viršuje: `MAIN MENU`, `INVENTORY`, `SAVE`, `SHOP` ir `ACHIEVMENTS` leidžia mums patekti į kitas erdves![4](https://user-images.githubusercontent.com/78691849/236306960-520c0457-c21a-45b8-aea0-9dae2ec25915.png)

Žaidimas prasideda kai pradedam pirmąjį lygį, pačio žaidimo ekrane yra keli mygtukai bei funkcijos. Kairiajame šone matome lentelę `ITEMS` kurioje bus atvaizduojami mūsų daiktai įgyti žaidžiant žaidimą. Apatiniame dešiniajame ampe matome galimas atakas bei gyvybių ir man'os mygtukus `(mana- reikalinga norint atakuoti arba atgaut gyvybes)`. Pašiam dešiniajame šone matome kitą lentelę kurioje konkrečiai yra rodoma kiek ir kokiu kvalifikacijų žaidimo metu įgyti daiktai mums davė.
![5](https://user-images.githubusercontent.com/78691849/236309229-6d106356-693b-46fe-9fec-167805d02dce.png)



