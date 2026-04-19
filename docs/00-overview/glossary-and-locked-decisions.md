# KnowledgeCoach — واژه‌نامه و تصمیم‌های تثبیت‌شده

## مقدمه

این سند برای حفظ یک زبان مشترک در پروژه و جلوگیری از drift مفهومی تهیه شده است. بخش اول، واژه‌های کلیدی محصول را تعریف می‌کند و بخش دوم، تصمیم‌های قطعی محصول را ثبت می‌کند.

---

## واژه‌نامه

### KnowledgeItem
یک واحد دانشی پایه که می‌تواند متن، لینک، فایل یا PDF باشد و قابلیت استفاده در ingest، learning، interaction و assessment را دارد.

### IngestionProfile
مجموعه‌ای از تنظیمات و policyها برای پردازش content؛ مانند strategy مربوط به chunking، اندازه chunk، overlap، tokenization و embedding reference.

### IngestionJob
یک اجرای مشخص از ingest روی یک KnowledgeItem.

### ContentChunk
بخشی chunk‌شده از content که پایه retrieval و grounding را می‌سازد.

### ChunkEmbedding
نمایش برداری یک chunk برای similarity و retrieval.

### LearningPath
یک ساختار هدف‌مند یادگیری که از چند step تشکیل می‌شود و از contentهای موجود استفاده می‌کند.

### LearningPathStep
یک مرحله از path که هدف آموزشی مشخص دارد و چند content را در خود جمع می‌کند.

### UserLearningPath
ثبت enrollment یک user روی path.

### UserLearningStepProgress
ثبت وضعیت پیشرفت user روی یک step.

### Pace Profile
یکی از سه بازه زمانی مورد انتظار برای انجام path یا step:
- سریع
- معمولی
- کند

### Benchmark
مقایسه وضعیت یک user با expectation تعریف‌شده یا با جامعه کاربران.

### ChatSession
گفتگوی context-aware روی یک scope مشخص.

### AssessmentBlueprint
تنظیمات آزمون شامل scope، تعداد سؤال، نوع سؤال، زمان و در صورت نیاز weightها.

### GeneratedAssessment
نسخه تولیدشده assessment برای یک user مشخص.

### AssessmentAttempt
اجرای واقعی آزمون توسط user.

### Common Question Signal
سیگنالی که نشان می‌دهد یک سؤال یا topic برای دیگران نیز پرتکرار یا ابهام‌برانگیز بوده است.

---

## تصمیم‌های تثبیت‌شده

1. محصول فقط برای دانش سازمانی نیست.  
2. متخصص مستقل نیز کاربر اصلی محصول است.  
3. PDF منبع دانشی درجه‌یک است.  
4. ingestion بخشی از ارزش اصلی محصول است.  
5. chunking و retrieval در مدل مفهومی حضور دارند.  
6. content reusable است.  
7. path step-based است.  
8. path و step time-aware هستند.  
9. سه pace profile وجود دارد: سریع، معمولی، کند.  
10. benchmarking بخشی از value اصلی محصول است.  
11. interaction باید scoped باشد.  
12. common-question signal بخشی از interaction layer است.  
13. assessment در سطح step و path وجود دارد.  
14. generated assessment برای هر user اختصاصی است.  
15. path-level assessment می‌تواند weight-aware باشد.  
16. descriptive grading AI-assisted است.  
17. AI capability است، نه core domain identity.