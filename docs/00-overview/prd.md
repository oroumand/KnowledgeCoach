# KnowledgeCoach — سند نیازمندی‌های محصول (PRD)

## مقدمه

این سند، نیازمندی‌های محصول KnowledgeCoach را به‌صورت جامع و مرجع‌محور تعریف می‌کند. هدف از این سند آن است که تیم محصول، طراح تجربه کاربری، معمار نرم‌افزار، توسعه‌دهندگان، تحلیل‌گران و هر فرد جدیدی که وارد پروژه می‌شود، بتواند با مطالعه آن درک دقیقی از محصول، محدوده آن، قابلیت‌ها، رفتارهای مورد انتظار، و تصمیم‌های تثبیت‌شده داشته باشد.

این سند مستقل از تکنولوژی پیاده‌سازی نوشته شده است. بنابراین، محتوای آن نباید به زبان برنامه‌نویسی، فریم‌ورک، ORM، ساختار solution، یا providerهای خاص وابسته باشد. اگر implementation stack تغییر کند، حقیقت محصول همچنان باید از طریق این سند قابل فهم و قابل پیگیری باقی بماند.

---

## 1. تعریف محصول

KnowledgeCoach یک پلتفرم دانش‌محور برای مدیریت دانش، ساخت مسیر یادگیری، تعامل هوشمند با محتوا، ارزیابی یادگیری، و تحلیل پیشرفت و رفتار یادگیرنده است. این محصول با این فرض طراحی شده که دانش به‌خودی‌خود ارزش نهایی ایجاد نمی‌کند، مگر زمانی که بتواند:
- در دسترس و قابل استفاده باشد
- به یک مسیر یادگیری تبدیل شود
- قابل گفتگو و پرسش‌وپاسخ باشد
- مبنای assessment قرار گیرد
- و از روی مصرف آن، بینش‌های تحلیلی قابل استفاده استخراج شود

KnowledgeCoach برای هر دو سناریوی زیر تعریف شده است:
- دانش و یادگیری در سازمان‌ها و تیم‌ها
- دانش و یادگیری عمومی، تخصصی، حرفه‌ای و فردی

---

## 2. چشم‌انداز محصول

چشم‌انداز محصول این است که هر knowledge asset واردشده به سیستم بتواند به یک learning asset فعال تبدیل شود. در این چشم‌انداز، محتوایی که امروز به‌صورت خام در قالب PDF، لینک، فایل یا متن وجود دارد، باید فردا بتواند:
- در یک path استفاده شود
- روی آن chat و Q&A انجام شود
- برای assessment به کار رود
- و data تولید کند که هم user و هم creator بتوانند از آن برای تصمیم‌گیری بهتر استفاده کنند

به بیان ساده، محصول می‌خواهد شکاف بین «داشتن دانش» و «یادگیری واقعی و سنجش‌پذیر» را از بین ببرد.

---

## 3. اهداف محصول

### 3.1 اهداف اصلی

اولین هدف، تبدیل دانش پراکنده به یک دارایی قابل استفاده است. محصول باید بتواند دانش را دریافت کند، نگه دارد، ingest کند، و آماده interaction و learning کند.

دومین هدف، تبدیل دانش به مسیر یادگیری است. محصول باید به افراد اجازه دهد از روی محتواهای موجود، pathهای مرحله‌محور و reusable بسازند.

سومین هدف، ایجاد تعامل grounded با محتواست. کاربر باید بتواند از محتوا و stepها سؤال بپرسد و با آن‌ها گفت‌وگو کند.

چهارمین هدف، ایجاد assessment مبتنی بر همان محتوای واقعی سیستم است. assessment نباید از knowledge system جدا باشد.

پنجمین هدف، ارائه pace awareness و benchmarking است. کاربر باید بفهمد با چه سرعتی جلو می‌رود، آیا on-track است یا نه، و نسبت به جامعه کاربران چه وضعیتی دارد.

### 3.2 اهداف ثانویه

از اهداف ثانویه می‌توان به این موارد اشاره کرد:
- کمک به onboarding و upskilling
- کاهش هزینه تولید آموزش از صفر
- reuse دانش موجود
- کمک به متخصص‌های مستقل برای انتشار دانش به‌صورت ساختاریافته
- فراهم کردن پایه رشد محصول در آینده

---

## 4. کاربران هدف

### متخصص / مدرس / سازنده مسیر
این کاربر معمولاً نقش تولیدکننده یا curator دانش را دارد. او محتواها را وارد می‌کند، آن‌ها را در مسیرهای آموزشی قرار می‌دهد، برای path و step زمان‌بندی تعیین می‌کند، assessment تعریف می‌کند، و مسیر را منتشر می‌کند.

نیازهای این کاربر:
- ورود محتوای ساده و منعطف
- reuse محتوا
- ساخت path مرحله‌محور
- تنظیم زمان‌بندی یادگیری
- تعریف assessment
- دیدن آمار مصرف و completion

### یادگیرنده
این کاربر می‌خواهد مسیری روشن و قابل دنبال کردن داشته باشد، stepها را جلو ببرد، روی محتوا سؤال بپرسد، assessment بگیرد، و بداند نسبت به expectation و دیگران چه وضعیتی دارد.

نیازهای این کاربر:
- وضوح در مسیر
- دسترسی آسان به content
- chat و Q&A
- assessment
- بازخورد و benchmark
- درک pace و وضعیت شخصی

### مدیر / مدیر دانش / مدیر آموزشی
این کاربر می‌خواهد دانش را به learning asset تبدیل کند و بفهمد واقعاً چگونه از آن استفاده شده است.

نیازهای این کاربر:
- visibility روی adoption و completion
- تبدیل دانش به مسیرهای قابل استفاده
- تحلیل رفتار کاربران در pathها

### متخصص مستقل
این کاربر می‌خواهد محتوای تخصصی خود را وارد کند، path بسازد، آن را عمومی کند و دیگران از آن استفاده کنند.

نیازهای این کاربر:
- استقلال از ساختار سازمانی
- path publishing
- reuse و maintainability محتوا
- analytics درباره استفاده از مسیرهای منتشرشده

---

## 5. محدوده محصول

### 5.1 در محدوده

محصول در وضعیت فعلی باید این capabilityها را پوشش دهد:
- knowledge intake
- ingestion and retrieval readiness
- path and step modeling
- reusable content
- public/private path
- enrollment
- progress tracking
- timing and pace profiles
- scoped interaction
- common question signals
- assessment configuration
- assessment generation
- timed execution
- grading and feedback
- learning analytics
- benchmarking

### 5.2 خارج از محدوده اولیه

در نسخه اولیه، این موارد خارج از scope هستند:
- collaboration real-time
- marketplace
- certification workflow پیچیده
- anti-cheating و proctoring
- external integrations گسترده
- social learning features
- moderation workflowهای پیچیده
- advanced enterprise analytics

---

## 6. نیازمندی‌های عملکردی

## 6.1 مدیریت و ورود دانش

سیستم باید امکان ورود دانش را از چهار نوع منبع اصلی فراهم کند:
- متن
- لینک
- فایل
- PDF

برای هر KnowledgeItem، سیستم باید:
- metadata را نگه دارد
- فایل اصلی را در صورت وجود حفظ کند
- امکان مشاهده محتوا را فراهم کند
- و در صورت file-backed بودن، امکان دانلود را بدهد

PDF در این محصول جایگاه مهمی دارد. PDF فقط یک فایل ذخیره‌شده نیست؛ بلکه منبع دانشی واقعی است که باید در چرخه ingest قرار بگیرد و برای retrieval، pathing و assessment قابل استفاده شود.

### رفتار مورد انتظار
- user بتواند content جدید ثبت کند
- content بعد از ثبت بتواند وارد ingest شود
- file-backed content downloadable باشد
- content detail قابل مشاهده باشد
- system بداند content در چه وضعیت ingest قرار دارد

---

## 6.2 ingestion و آمادگی برای RAG

محصول باید content را برای interaction و generation آماده کند. این آماده‌سازی باید مفهومی روشن در مدل محصول داشته باشد.

مراحل اصلی ingestion عبارت‌اند از:
- استخراج متن
- preprocessing و normalization
- chunking
- embedding
- آماده شدن برای retrieval

این موضوع فقط concern فنی backend نیست. باید بتوان در سطح محصول پرسید:
- آیا این content آماده interaction است؟
- با چه تنظیماتی chunk شده؟
- چند chunk دارد؟
- با چه profile یا strategy پردازش شده؟

بنابراین، نیاز است مفاهیمی مانند IngestionProfile، IngestionJob، ContentChunk و ChunkEmbedding در حقیقت محصول حضور داشته باشند.

### رفتار مورد انتظار
- هر content مهم بتواند ingest شود
- ingestion status قابل مشاهده باشد
- system traceability لازم را برای chunking و embedding نگه دارد
- contentهای ready بتوانند مبنای chat و assessment generation باشند

---

## 6.3 reusable بودن محتوا

محصول باید روی اصل reuse بنا شود. یک content item باید بتواند در چند path و چند step استفاده شود. pathها نباید نسخه‌های تکراری از content بسازند، بلکه باید به content reference بدهند.

این تصمیم برای maintainability، کیفیت knowledge graph، و جلوگیری از duplication ضروری است.

### رفتار مورد انتظار
- content یک‌بار وارد شود
- stepها بتوانند به contentهای موجود متصل شوند
- یک content بتواند در چند step/path ظاهر شود
- duplicate-awareness در حد پایه وجود داشته باشد

---

## 6.4 ساخت مسیر یادگیری

کاربر باید بتواند path بسازد، step تعریف کند، ترتیب stepها را تعیین کند، و contentها را به stepها وصل کند. path باید چیزی فراتر از یک مجموعه content باشد. path یک ساختار آموزشی هدف‌مند است.

### modeهای ساخت path
- دستی
- AI-assisted
- hybrid

در AI-assisted mode، سیستم می‌تواند از روی contentهای موجود پیشنهاد دهد، اما کاربر باید بتواند آن را ویرایش و تأیید کند.

### رفتار مورد انتظار
- ساخت path و step
- attach کردن contentها
- تعریف هدف و توضیح برای path
- انتشار path به‌صورت public/private

---

## 6.5 زمان‌مند بودن path و step

Path و step باید expected duration داشته باشند. این expected duration به‌صورت یک عدد واحد تعریف نمی‌شود، بلکه به شکل سه پروفایل pace تعریف می‌شود:
- سریع
- معمولی
- کند

این سه پروفایل باید هم در path و هم در step قابل تعریف باشند. هدف از این مدل این است که:
- user بداند انتظار زمانی معقول چیست
- system بتواند pace user را طبقه‌بندی کند
- analytics معنی‌دارتر شوند

### رفتار مورد انتظار
- creator بتواند expected durations را تعریف کند
- user pace نسبت به expectation قابل تشخیص باشد
- system بتواند user را در یکی از categories pace قرار دهد

---

## 6.6 enrollment و progress

محصول باید بین path اصلی و تجربه شخصی user روی path تمایز قائل شود. وقتی user یک path عمومی را انتخاب می‌کند، باید enrollment شخصی او ایجاد شود. progress نیز باید در context این enrollment نگهداری شود.

در سطح step، startedAt باید جزو اطلاعات ضروری باشد. بدون startedAt، pace analysis و progress واقعی ناقص خواهد بود.

### رفتار مورد انتظار
- user بتواند path را start کند
- step progress ثبت شود
- startedAt برای step وجود داشته باشد
- status و completion نیز قابل ثبت باشند
- user position در path روشن باشد

---

## 6.7 تعامل هوشمند (Chat / Q&A)

محصول باید interaction را به‌صورت scoped پشتیبانی کند. این یعنی کاربر بتواند روی:
- یک content خاص
- یک step خاص
- در صورت نیاز یک path
- یا knowledge base کلی‌تر

سؤال بپرسد و پاسخ grounded بگیرد.

پاسخ‌ها نباید generic و بی‌ارتباط با content واقعی باشند. grounding و retrieval بخش حیاتی این interaction است.

### رفتار مورد انتظار
- ایجاد و ادامه chat session
- context-aware answers
- استفاده از chunks و retrieval
- حفظ history گفتگو

---

## 6.8 common question signals

محصول باید بتواند تا حد ممکن از داده‌های interaction برای تولید signal استفاده کند. هدف این نیست که سیستم از روز اول clustering پیچیده داشته باشد، بلکه باید از ابتدا این concern را ببیند.

نمونه signalهای مورد انتظار:
- این سؤال را دیگران هم پرسیده‌اند
- این topic برای کاربران دیگر هم مبهم بوده
- این step سوال‌برانگیزتر از حد معمول است

### رفتار مورد انتظار
- system بتواند نشانه‌هایی از پرتکرار بودن سؤال‌ها ذخیره کند
- در UI بتوان signalهای ساده و مفید نمایش داد
- این signalها grounded به scope باشند

---

## 6.9 assessment

assessment در این محصول در دو سطح وجود دارد:
- step-level
- path-level

assessment باید configurable باشد. user یا creator باید بتواند:
- تعداد کل سؤال
- تعداد تستی
- تعداد تشریحی
- مدت زمان آزمون

را مشخص کند.

در path-level assessment، امکان تعریف weight برای stepها نیز باید وجود داشته باشد، تا distribution سؤال‌ها بر اساس وزن stepها انجام شود.

### رفتار مورد انتظار
- تعریف assessment blueprint
- step/path scope
- per-user generation
- رعایت counts و timing
- weight-aware generation در path-level

---

## 6.10 اجرای آزمون

assessment باید از generation تا grading یک lifecycle کامل داشته باشد:
- generate
- start
- answer
- submit manual
- auto-submit
- grade
- feedback

### رفتار مورد انتظار
- آزمون state داشته باشد
- timer enforce شود
- پاسخ‌ها ذخیره شوند
- آزمون در پایان نتیجه تولید کند

---

## 6.11 grading و feedback

grading باید دو مدل را پشتیبانی کند:
- grading قطعی برای MCQ
- grading AI-assisted برای descriptive

در پایان، user باید:
- score کل
- نتیجه
- feedback کلی
- و در صورت نیاز feedback جزئی‌تر
را ببیند.

---

## 6.12 analytics و benchmarking

analytics در این محصول فقط برای گزارش مدیریتی نیست. این analytics باید به user و creator کمک کند بهتر تصمیم بگیرند.

### path-level analytics
- started users count
- completed users count
- completion rate
- average completion time
- median completion time
- pace distribution

### step-level analytics
- average time spent
- median time spent
- completion rate
- drop-off count
- common question count

### user-level benchmark
- pace user نسبت به fast/normal/slow
- position user نسبت به community
- percentile یا signal مشابه
- ahead / on-track / behind بودن

---

## 7. الزامات تجربه کاربری

تجربه کاربری محصول باید این ویژگی‌ها را داشته باشد:
- کاربر همیشه بداند در کجای path قرار دارد
- content access ساده و روشن باشد
- path progression واضح باشد
- pace و benchmark به‌صورت انگیزه‌بخش و نه تنبیهی نمایش داده شوند
- interaction، learning و assessment disconnected حس نشوند
- assessment به‌عنوان بخشی طبیعی از learning journey تجربه شود

---

## 8. معیارهای قبولی محصول

اگر یک متخصص بتواند:
- content واقعی وارد کند
- آن را ingest کند
- path و step بسازد
- timing تعریف کند
- path را منتشر کند

و اگر یک user بتواند:
- path را enroll کند
- stepها را طی کند
- content را بخواند و دانلود کند
- chat/Q&A انجام دهد
- assessment بگیرد
- نتیجه و benchmark ببیند

آنگاه می‌توان گفت core product behavior محقق شده است.

---

## 9. تصمیم‌های تثبیت‌شده

در این محصول این تصمیم‌ها قفل شده‌اند و نباید بدون تصمیم جدید تغییر کنند:
- محصول فقط برای دانش سازمانی نیست
- متخصص مستقل کاربر اصلی است
- PDF first-class content source است
- ingestion concern اصلی محصول است
- chunking و retrieval در مدل مفهومی حضور دارند
- content reusable است
- path step-based است
- path و step time-aware هستند
- fast/normal/slow pace profiles وجود دارند
- benchmarking بخشی از value اصلی است
- common-question signals بخشی از interaction layer هستند
- assessment در step و path وجود دارد
- generated assessment per-user است
- path-level assessment می‌تواند weight-aware باشد
- descriptive grading با AI انجام می‌شود
- AI capability است، نه هویت دامنه