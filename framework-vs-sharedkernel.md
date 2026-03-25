# تفاوت Framework و SharedKernel

## مقدمه
در پروژه KnowledgeCoach دو بخش مهم برای کدهای مشترک وجود دارد:

- BuildingBlocks.SharedKernel
- BuildingBlocks.Framework

این دو بخش نقش‌های متفاوتی دارند و مرزبندی صحیح بین آن‌ها برای سلامت معماری بسیار مهم است.

---

## SharedKernel چیست؟

SharedKernel شامل مفاهیم پایه دامنه‌ای است که:

- معنی business دارند
- بین چند ماژول مشترک هستند
- پایدار و کم‌تغییر هستند
- به لایه‌های application یا infrastructure وابسته نیستند

### نمونه‌ها
- Entity
- AggregateRoot
- ValueObject
- DomainEvent

این مفاهیم بخشی از "زبان دامنه" هستند.

---

## Framework چیست؟

Framework شامل abstractionها و ابزارهای فنی برای اجرای use caseها در application layer است.

این بخش شامل مواردی است که:

- به اجرای سناریوهای نرم‌افزار کمک می‌کنند
- دامنه‌ای نیستند
- بین ماژول‌ها مشترک هستند
- قابل استفاده در application layer هستند

### نمونه‌ها
- ICommand
- IQuery
- CommandHandler
- QueryHandler
- Dispatcher
- Result
- Pagination

---

## تصمیم مهم: ICommand در Framework

در این پروژه، abstraction مربوط به Command در پروژه Framework قرار داده شده است:

- ICommand
- ICommand<TResult>

### دلیل این تصمیم

ICommand یک مفهوم دامنه‌ای نیست.

این abstraction نشان‌دهنده:
"یک درخواست برای اجرای یک use case در سیستم"

است.

این مفهوم:
- مربوط به application layer است
- بخشی از orchestration سیستم است
- در مدل دامنه وجود ندارد

---

## چرا ICommand در SharedKernel قرار نمی‌گیرد؟

اگر ICommand وارد SharedKernel شود:

- مرز بین domain و application از بین می‌رود
- SharedKernel به‌مرور بزرگ و غیرقابل کنترل می‌شود
- abstractionهای فنی وارد لایه دامنه می‌شوند
- وابستگی‌های ناخواسته بین لایه‌ها ایجاد می‌شود

این یک anti-pattern است.

---

## قانون تصمیم‌گیری

برای تشخیص اینکه یک کد باید در SharedKernel باشد یا Framework، از این قانون استفاده می‌کنیم:

### اگر پاسخ این سؤال "بله" است:
"آیا این مفهوم در زبان business معنا دارد؟"

👉 در SharedKernel یا Domain قرار می‌گیرد

---

### اگر پاسخ این سؤال "بله" است:
"آیا این مفهوم به نحوه اجرای use caseها مربوط است؟"

👉 در Framework قرار می‌گیرد

---

## مثال

### Domain (SharedKernel یا Module)
- KnowledgeItem
- LearningPath
- ValueObject
- DomainEvent

### Application / Framework
- CreateKnowledgeItemCommand
- GetLearningPathQuery
- CommandHandler
- Dispatcher

---

## جمع‌بندی

SharedKernel باید:
- کوچک بماند
- فقط شامل مفاهیم دامنه‌ای پایه باشد

Framework باید:
- محل abstractionهای فنی و application-level باشد
- ابزار اجرای use caseها را فراهم کند

حفظ این مرز یکی از مهم‌ترین عوامل جلوگیری از خراب شدن معماری در طول زمان است.