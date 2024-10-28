<div id="page">

<div id="main" class="aui-page-panel">

<div id="main-header">

<div id="breadcrumb-section">

1.  [ProgInz TG08.3](index.html)
2.  [ProgInz TG08.3 Home](ProgInz-TG08.3-Home_66036.html)
3.  [Dev Guidelines](Dev-Guidelines_5406732.html)

</div>

# <span id="title-text"> ProgInz TG08.3 : Git management </span>

</div>

<div id="content" class="view">

<div class="page-metadata">

Created by <span class="author"> Filip Belina</span> on Oct 27, 2024

</div>

<div id="main-content" class="wiki-content group">

Ovaj page če opisati procese kojima koristimo github, ovaj prikaz govori
o tome u sklopu Ridera, ali ideje su iste bez obzira na koji git
managment tool bude odabran.

#### 1. Kloniranje repozitorija

Ako repozitorij još nije kloniran na lokalno računalo:

- Otvori Rider i odaberi **Get from Version Control** s početnog
  zaslona.

  <span class="confluence-embedded-file-wrapper image-center-wrapper confluence-embedded-manual-size"><img src="attachments/5406733/5406758.png?width=314"
  class="confluence-embedded-image image-center" loading="lazy"
  data-image-src="attachments/5406733/5406758.png" data-height="356"
  data-width="314" data-unresolved-comment-count="0"
  data-linked-resource-id="5406758" data-linked-resource-version="1"
  data-linked-resource-type="attachment"
  data-linked-resource-default-alias="IZbIOO6.png"
  data-base-url="https://gumenepatkice.atlassian.net/wiki"
  data-linked-resource-content-type="image/png"
  data-linked-resource-container-id="5406733"
  data-linked-resource-container-version="1"
  data-media-id="77dc2ab5-910d-402c-96ac-bdcc755f2014"
  data-media-type="file" width="314" /></span>

- Upiši URL GitHub repozitorija, odaberi lokalnu mapu za kloniranje i
  klikni na **Clone**.

#### 2. Kreiranje nove grane iz *main* grane

Da bi kreirao novu granu:

- Provjeri da si na glavnoj (*main*) grani tako da u donjem desnom kutu
  Rider prozora vidiš naziv trenutne grane.

- Desnim klikom na trenutnu granu ili klikom na izbornik **Git** u
  alatnoj traci odaberi **New Branch...**.  

  <span class="confluence-embedded-file-wrapper image-center-wrapper confluence-embedded-manual-size"><img src="attachments/5406733/5996551.png?width=273"
  class="confluence-embedded-image image-center" loading="lazy"
  data-image-src="attachments/5406733/5996551.png" data-height="326"
  data-width="375" data-unresolved-comment-count="0"
  data-linked-resource-id="5996551" data-linked-resource-version="1"
  data-linked-resource-type="attachment"
  data-linked-resource-default-alias="b7jOpUH.png"
  data-base-url="https://gumenepatkice.atlassian.net/wiki"
  data-linked-resource-content-type="image/png"
  data-linked-resource-container-id="5406733"
  data-linked-resource-container-version="1"
  data-media-id="0b042b73-3ea7-40d3-9e4f-f4b9ab0fb383"
  data-media-type="file" width="273" /></span><span class="confluence-embedded-file-wrapper image-center-wrapper confluence-embedded-manual-size"><img src="attachments/5406733/5472428.png?width=379"
  class="confluence-embedded-image image-center" loading="lazy"
  data-image-src="attachments/5406733/5472428.png" data-height="185"
  data-width="379" data-unresolved-comment-count="0"
  data-linked-resource-id="5472428" data-linked-resource-version="1"
  data-linked-resource-type="attachment"
  data-linked-resource-default-alias="fGMf8yR.png"
  data-base-url="https://gumenepatkice.atlassian.net/wiki"
  data-linked-resource-content-type="image/png"
  data-linked-resource-container-id="5406733"
  data-linked-resource-container-version="1"
  data-media-id="ea97f111-6cf2-4587-a72c-8fce556afb63"
  data-media-type="file" width="379" /></span>

- Unesi naziv nove grane, npr. `feat/TicketKey-TicketName`, i klikni
  **Create**. Rider će te automatski prebaciti na novu granu.

- Naziv grane uvijek mora biti jedan od 4:  
  `feat/TicketKey-TicketName`,  
  `bug/TicketKey-TicketName`,  
  `test/TicketKey-TicketName`,  
  `type/TicketName`

#### 3. Dodavanje i commitanje promjena

Nakon što napraviš promjene u projektu:

- Otvori alatnu traku Git-a s **View \> Tool Windows \> Git** ili klikni
  na **Commit** ikonu u donjem dijelu zaslona.

- Označi promijenjene datoteke koje želiš dodati u commit ili označi sve
  promjene.

- Upiši opis promjena u polje za poruku.

- Klikni na **Commit** ili **Commit and Push** (ako želiš odmah poslati
  promjene na GitHub).

#### 4. Slanje promjena na GitHub (push)

Ako si samo napravio commit i nisi još poslao promjene:

- Otvori **Git** alatnu traku.

- Klikni **Push** ili desni klik na granu i odaberi **Push**. Time ćeš
  poslati promjene na GitHub repozitorij.

#### 5. Povlačenje najnovijih promjena s GitHub-a (pull)

Ako želiš povući najnovije promjene s *main* grane na GitHubu:

- Prebaci se na *main* granu kroz Git izbornik u donjem desnom kutu ili
  pomoću **Git** alatne trake.

  <span class="confluence-embedded-file-wrapper image-center-wrapper confluence-embedded-manual-size"><img src="attachments/5406733/5472435.png?width=596"
  class="confluence-embedded-image image-center" loading="lazy"
  data-image-src="attachments/5406733/5472435.png" data-height="394"
  data-width="596" data-unresolved-comment-count="0"
  data-linked-resource-id="5472435" data-linked-resource-version="1"
  data-linked-resource-type="attachment"
  data-linked-resource-default-alias="UFBHMWL.png"
  data-base-url="https://gumenepatkice.atlassian.net/wiki"
  data-linked-resource-content-type="image/png"
  data-linked-resource-container-id="5406733"
  data-linked-resource-container-version="1"
  data-media-id="e15b60a2-1712-4e9f-a029-8e76e261eebe"
  data-media-type="file" width="596" /></span>

- Klikni na **Fetch, Pull ili Update** kako bi povukao najnovije
  promjene u svoj lokalni repozitorij.

#### 6. Spajanje promjena s *main* granom

Kad završiš rad na `nova-grana` i želiš je spojiti s *main*:

- Otvori Github te na projektu napravi novi pull request baziran na
  grani koju želiš spojiti u glavni projekt.

- Nakon pull requesta potrebno je čekati odobrenje 2 druga developera,
  ili dobiti explicitno dopuštenje za merganje od projekt leada

- Kada su svi uvijeti ispunjeni (dovoljan broj aproveova, bez ne
  razriješenih komentara, bez merge conflikata) dozvoljeno je dovršiti
  pr pritiskom na merge.

#### 7. Nakon završetka na Jiri zatvoriti ticket

Potrebno je otiči na ticket i prebaciti njegov state na closed

</div>

<div class="pageSection group">

<div class="pageSectionHeader">

## Attachments:

</div>

<div class="greybox" align="left">

<img src="images/icons/bullet_blue.gif" width="8" height="8" />
[image-20241026-000120.png](attachments/5406733/5373958.png)
(image/png)  
<img src="images/icons/bullet_blue.gif" width="8" height="8" />
[IZbIOO6.png](attachments/5406733/5406758.png) (image/png)  
<img src="images/icons/bullet_blue.gif" width="8" height="8" />
[b7jOpUH.png](attachments/5406733/5996551.png) (image/png)  
<img src="images/icons/bullet_blue.gif" width="8" height="8" />
[fGMf8yR.png](attachments/5406733/5472428.png) (image/png)  
<img src="images/icons/bullet_blue.gif" width="8" height="8" />
[UFBHMWL.png](attachments/5406733/5472435.png) (image/png)  

</div>

</div>

</div>

</div>

<div id="footer" role="contentinfo">

<div class="section footer-body">

Document generated by Confluence on Oct 27, 2024 18:23

<div id="footer-logo">

[Atlassian](http://www.atlassian.com/)

</div>

</div>

</div>

</div>
