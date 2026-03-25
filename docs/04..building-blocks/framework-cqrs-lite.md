# CQRS سبک در Framework

## مقدمه
در پروژه KnowledgeCoach برای لایه Application از یک الگوی سبک command/query استفاده می‌شود.

هدف این الگو:
- شفاف شدن use caseها
- جدا شدن عملیات خواندن از عملیات تغییر
- یکدست شدن ساختار handlerها
- جلوگیری از پخش شدن منطق application در endpointها

این پیاده‌سازی عمداً سبک نگه داشته شده است و قرار نیست یک CQRS پیچیده یا کامل باشد.

## اجزای فعلی

### ICommand
قراردادی برای نمایش یک درخواست که قرار است تغییری در سیستم ایجاد کند.

نمونه‌های آینده:
- CreateKnowledgeItemCommand
- PublishLearningPathCommand
- SubmitAssessmentCommand

### IQuery<TResult>
قراردادی برای نمایش یک درخواست خواندنی که قرار است داده‌ای را برگرداند.

نمونه‌های آینده:
- GetKnowledgeItemByIdQuery
- GetLearningPathDetailsQuery
- GetUserProgressQuery

### ICommandHandler
مسئول اجرای یک command است.

### IQueryHandler
مسئول اجرای یک query است.

## تفاوت Command و Query

### Command
- برای تغییر state
- معمولاً اثر جانبی دارد
- ممکن است چیزی برنگرداند یا یک نتیجه مشخص برگرداند

### Query
- برای خواندن داده
- نباید state سیستم را تغییر دهد
- همیشه نتیجه‌ای برای خواندن برمی‌گرداند

## چرا این الگو در Framework قرار دارد؟
این abstractionها مفاهیم دامنه‌ای نیستند.
آن‌ها به نحوه اجرای use caseها در application layer مربوط می‌شوند.

به همین دلیل:
- در SharedKernel قرار نمی‌گیرند
- در Domain ماژول‌ها هم قرار نمی‌گیرند
- در Framework نگهداری می‌شوند

## چرا این پیاده‌سازی سبک است؟
در این مرحله از پروژه، عمداً این قابلیت‌ها را هنوز اضافه نکرده‌ایم:

- pipeline behavior
- validation pipeline
- transaction pipeline
- event publishing pipeline
- mediator خارجی
- پیچیدگی‌های کامل CQRS

دلیل این تصمیم:
- کوچک نگه داشتن foundation
- جلوگیری از over-engineering
- رشد تدریجی framework فقط بر اساس نیاز واقعی

## اصل مهم
هر use case در application layer بهتر است به‌صورت یک command یا query مستقل مدل شود.
این کار باعث می‌شود:
- مسئولیت‌ها کوچک بمانند
- تست‌پذیری بهتر شود
- endpointها سبک بمانند
- منطق application ساختار واضح‌تری پیدا کند

## جمع‌بندی
در پروژه KnowledgeCoach، CQRS به‌صورت سبک و کاربردی استفاده می‌شود.
هدف از این انتخاب، ساخت یک architecture قابل فهم و قابل نگهداری است، نه پیاده‌سازی یک الگوی پیچیده فقط به‌خاطر شهرت آن.