# KnowledgeCoach — سند MVP

## مقدمه

MVP در KnowledgeCoach نباید فقط یک prototype کوچک و ناقص باشد، چون ارزش این محصول از اتصال چند capability به هم ایجاد می‌شود. اگر این اتصال از بین برود، چیزی که ساخته می‌شود دیگر نماینده واقعی محصول نخواهد بود.

بنابراین، MVP در اینجا به معنی «کوچک‌ترین نسخه‌ای که core value محصول را به‌صورت end-to-end نشان بدهد» است.

---

## هدف MVP

هدف MVP این است که نشان دهد دانش واقعی می‌تواند در این سیستم به یک تجربه یادگیری واقعی تبدیل شود.

این تجربه باید شامل این زنجیره باشد:
- content intake
- ingest readiness
- path creation
- step-based progression
- interaction
- assessment
- pace awareness
- basic analytics

---

## سناریوی مرجع MVP

سناریوی مرجع MVP به این صورت است:

یک متخصص تعدادی content واقعی، شامل PDF، وارد سیستم می‌کند. سیستم content را ingest می‌کند و آن را برای retrieval آماده می‌سازد. متخصص از روی همین contentها یک path می‌سازد، step تعریف می‌کند، برای path و step expected durations تعیین می‌کند، و path را به‌صورت عمومی منتشر می‌کند.

سپس یک user دیگر path را انتخاب می‌کند، در آن enroll می‌شود، stepها را شروع می‌کند، content را مطالعه و در صورت نیاز دانلود می‌کند، روی content یا step سؤال می‌پرسد، assessment مرحله یا مسیر را دریافت می‌کند، assessment برای او به‌صورت اختصاصی تولید می‌شود، نتیجه و feedback را می‌بیند، و pace و basic benchmark خود را مشاهده می‌کند.

اگر این سناریو به‌صورت کامل کار کند، MVP موفق است.

---

## آنچه در MVP باید وجود داشته باشد

### 1. ورود محتوا
MVP باید حداقل از text، link و PDF پشتیبانی کند. PDF به‌دلیل اهمیتش در سناریوهای واقعی، حتماً باید در MVP حاضر باشد. فایل اصلی باید در صورت وجود، downloadable باشد.

### 2. ingest
محتوا باید status ingest داشته باشد و بتواند برای retrieval و interaction آماده شود. لازم نیست تمام پیچیدگی‌های ingestion در MVP surfaced شوند، اما از نظر behavior باید content ingest-ready باشد.

### 3. path و step
کاربر سازنده باید بتواند path بسازد، step اضافه کند، contentها را به step وصل کند، و path را private یا public کند.

### 4. timing
برای هر path و هر step باید three pace profiles تعریف شوند:
- سریع
- معمولی
- کند

### 5. enrollment و progress
user باید بتواند path عمومی را انتخاب کند، step را start کند، startedAt برای step ثبت شود، و completion state نیز وجود داشته باشد.

### 6. interaction
حداقل Q&A یا chat روی content و step باید وجود داشته باشد. این interaction باید retrieval-grounded باشد.

### 7. assessment
assessment باید در سطح step و path وجود داشته باشد. باید configurable باشد و برای هر user اختصاصی تولید شود.

### 8. grading
MCQ باید deterministic grade شود و descriptive answer باید AI-assisted grade شود. user باید score و feedback را ببیند.

### 9. analytics پایه
حداقل این داده‌ها باید وجود داشته باشند:
- started users count برای path
- completed users count برای path
- completion rate پایه
- average step time
- pace user نسبت به expectation
- در صورت وجود داده کافی، signal ساده common questions

---

## آنچه خارج از MVP است

در MVP لازم نیست:
- analyticsهای خیلی پیشرفته و چندلایه بسازیم
- clustering پیچیده برای question trends داشته باشیم
- manual grading workflow اضافه کنیم
- integrationهای بیرونی گسترده پیاده کنیم
- versioning پیچیده content/path طراحی کنیم
- anti-cheating پیشرفته داشته باشیم
- certificate یا social learning features بسازیم

---

## اولویت‌بندی در MVP

### اولویت بسیار بالا
- PDF intake
- ingestion readiness
- path/step structure
- reusable content
- public path
- enrollment
- step progress with startedAt
- path/step timing
- scoped Q&A
- step/path assessment
- grading
- result display

### اولویت بالا
- pace classification
- basic benchmark display
- average step time
- basic common-question signal

### اولویت متوسط
- richer analytics
- stronger duplicate-awareness
- smarter question similarity logic

---

## معیار موفقیت MVP

MVP زمانی موفق است که:
- یک متخصص واقعاً بتواند content وارد کند
- از روی آن path بسازد
- timing تعریف کند
- path را منتشر کند
- یک user واقعاً path را طی کند
- روی آن chat کند
- assessment واقعی بگیرد
- نتیجه و pace خود را بفهمد

MVP در این محصول زمانی معتبر است که «یادگیری مبتنی بر دانش» را به‌صورت کامل و واقعی، هرچند در سطحی ساده‌تر، نمایش دهد.