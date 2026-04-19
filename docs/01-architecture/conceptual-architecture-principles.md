# KnowledgeCoach — اصول معماری مفهومی محصول

## مقدمه

این سند درباره معماری مفهومی محصول است، نه معماری فنی implementation. هدف این است که مرزهای فکری و concernهای اصلی محصول روشن بمانند و اگر بعداً stack فنی، framework یا ساختار پروژه تغییر کرد، فهم محصول دچار drift نشود.

---

## اصل 1: حقیقت محصول مستقل از implementation است

محصول باید بتواند بدون اشاره به زبان، framework، ORM یا ساختار پروژه توضیح داده شود. اگر implementation stack تغییر کند، نباید لازم باشد دوباره محصول را از نو تعریف کنیم.

---

## اصل 2: AI capability است، نه core identity

AI باید در orchestration use caseها، retrieval، generation و grading استفاده شود، اما نباید تعریف‌کننده مفاهیم اصلی دامنه باشد. path، step، content، progress و assessment باید بدون provider خاص AI نیز معنا داشته باشند.

---

## اصل 3: ناحیه‌های Knowledge، Learning، Interaction، Assessment و Analytics متمایز اما متصل‌اند

این ناحیه‌ها باید از نظر مفهومی مستقل فهمیده شوند، اما در تجربه محصول روی هم اثر بگذارند و با هم کار کنند.

---

## اصل 4: chunking و retrieval فقط concern فنی نیستند

از آنجا که Q&A، assessment generation، grading context و explainability به retrieval وابسته‌اند، مفاهیمی مثل chunk، ingestion profile، embedding و source reference باید در مدل مفهومی حضور داشته باشند.

---

## اصل 5: scheduling concern اصلی یادگیری است

زمان‌مندی path و step بخش جانبی محصول نیست. expected duration و pace profile بخشی از تجربه learning هستند.

---

## اصل 6: analytics باید برای تصمیم‌گیری مفید باشند

analytics در این محصول برای dashboard صرف ساخته نشده‌اند. باید به user و creator کمک کنند:
- pace را بفهمند
- stepهای سخت را تشخیص دهند
- quality مسیر را ارزیابی کنند

---

## اصل 7: reuse بر duplicate مقدم است

اگر reuse از ابتدا درست مدل نشود، محصول خیلی سریع به مجموعه‌ای از contentهای تکراری و pathهای ناسازگار تبدیل می‌شود.

---

## اصل 8: assessment باید grounded باشد

assessment زمانی معتبر است که به content و chunkهای واقعی متصل باشد. این grounding برای explainability، quality control و اعتمادپذیری ضروری است.

---

## اصل 9: common question signal بخشی از interaction layer است

محصول فقط نباید پاسخ بدهد؛ باید بتواند از interactionها signalهایی درباره سؤال‌های پرتکرار یا نقاط ابهام رایج استخراج کند.