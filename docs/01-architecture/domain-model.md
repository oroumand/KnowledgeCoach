# KnowledgeCoach — Domain Model

## 1. Purpose

This document defines the conceptual domain model of KnowledgeCoach. It is intentionally more technical than the other product documents, but it still remains implementation-independent. Its purpose is to provide a precise shared understanding of the core entities, relationships, and business rules that define the product.

The model covers the core conceptual areas of the product:
- Knowledge
- Ingestion
- Retrieval / Interaction
- Learning
- Assessment
- Analytics

---

## 2. Conceptual Subdomains

### Identity
Responsible for user identity, ownership, authorship, and enrollment context.

### Knowledge
Responsible for content assets that enter the system and become reusable knowledge units.

### Ingestion
Responsible for converting raw content into retrieval-ready assets through extraction, normalization, chunking, and embedding.

### Retrieval / Interaction
Responsible for scoped chat, Q&A, retrieval grounding, and tracking content/chunk usage in AI-assisted interactions.

### Learning
Responsible for paths, steps, enrollment, progress, pacing, and expected durations.

### Assessment
Responsible for configurable assessments, user-specific generated exams, timed execution, answers, grading, and feedback.

### Analytics
Responsible for statistical and comparative views over paths, steps, and user progress, including question trend signals.

---

## 3. Core Entities

### 3.1 KnowledgeItem
Represents a reusable knowledge asset.

**Attributes**
- Id
- Title
- Description
- ContentType
- SourceType
- RawContentReference
- ExtractedText
- Summary
- Metadata
- Visibility
- CreatedByUserId
- CreatedAt
- UpdatedAt
- Downloadable
- DownloadReference
- CurrentIngestionStatus

**Notes**
A KnowledgeItem exists independently from learning paths. It can later be attached to one or many path steps.

---

### 3.2 IngestionProfile
Represents the configuration used to ingest content.

**Attributes**
- Id
- Name
- ChunkingStrategy
- ChunkSize
- ChunkOverlap
- TokenizationStrategy
- EmbeddingModelReference
- NormalizationRules
- IsDefault
- CreatedAt

**Purpose**
Provides traceability for how content was processed and makes ingestion settings part of the conceptual model.

---

### 3.3 IngestionJob
Represents one execution of an ingestion process for a content item.

**Attributes**
- Id
- KnowledgeItemId
- IngestionProfileId
- Status
- StartedAt
- CompletedAt
- FailureReason
- ExtractedTextVersion
- ChunkCount
- EmbeddingCount

**Status examples**
- Pending
- Processing
- Ready
- Failed

---

### 3.4 ContentChunk
Represents a chunked segment of content.

**Attributes**
- Id
- KnowledgeItemId
- IngestionJobId
- Order
- RawText
- NormalizedText
- TokenCount
- StartOffset
- EndOffset
- SemanticLabel
- CreatedAt

**Purpose**
ContentChunk is foundational for retrieval, explainability, question generation, and source tracking.

---

### 3.5 ChunkEmbedding
Represents an embedding generated for a content chunk.

**Attributes**
- Id
- ContentChunkId
- EmbeddingModelReference
- VectorReference
- Dimensions
- CreatedAt

**Notes**
Depending on implementation, vectors may be stored inline or referenced through a vector store.

---

### 3.6 RetrievalReference
Represents the use of specific chunks in an AI-assisted operation.

**Attributes**
- Id
- ScopeType
- ScopeId
- KnowledgeItemId
- ContentChunkId
- UsageType
- RelevanceScore
- CreatedAt

**UsageType examples**
- ChatAnswer
- QuestionGeneration
- GradingContext
- SummaryGeneration

**Purpose**
Supports grounding traceability.

---

### 3.7 LearningPath
Represents a structured learning journey.

**Attributes**
- Id
- Title
- Description
- Goal
- Level
- Visibility
- PublicationStatus
- CreationMode
- AuthorId
- ExpectedDurationFast
- ExpectedDurationNormal
- ExpectedDurationSlow
- CreatedAt
- UpdatedAt

**Notes**
A path is not a container of copied content. It organizes reusable content into a learning structure.

---

### 3.8 LearningPathStep
Represents one step within a learning path.

**Attributes**
- Id
- LearningPathId
- Title
- Description
- Objective
- Order
- ExpectedDurationFast
- ExpectedDurationNormal
- ExpectedDurationSlow
- CreatedAt
- UpdatedAt

---

### 3.9 LearningStepContent
Association entity linking steps to content.

**Attributes**
- Id
- StepId
- KnowledgeItemId
- Order
- IsRequired
- Notes

**Purpose**
Enables many-to-many reuse between content and steps.

---

### 3.10 UserLearningPath
Represents a user’s enrollment and personal context on a path.

**Attributes**
- Id
- UserId
- LearningPathId
- Status
- StartedAt
- CompletedAt
- LastActivityAt

**Notes**
A public path is shared, but a user’s learning journey on that path is personal.

---

### 3.11 UserLearningStepProgress
Represents a user’s progress on a specific step.

**Attributes**
- Id
- UserLearningPathId
- StepId
- Status
- StartedAt
- CompletedAt
- LastAccessedAt
- TimeSpent
- PaceClassification

**PaceClassification**
- Fast
- Normal
- Slow
- BehindExpected

**Notes**
This entity supports learning progress and pace analysis.

---

### 3.12 ChatSession
Represents a context-aware chat session.

**Attributes**
- Id
- UserId
- ScopeType
- ScopeId
- Title
- CreatedAt
- UpdatedAt

**ScopeType**
- KnowledgeItem
- LearningStep
- LearningPath
- KnowledgeBase

---

### 3.13 ChatMessage
Represents one message in a chat session.

**Attributes**
- Id
- ChatSessionId
- Role
- Content
- CreatedAt

---

### 3.14 ChatQuestionSignal
Represents a signal that a question or confusion point is common.

**Attributes**
- Id
- ScopeType
- ScopeId
- CanonicalQuestionText
- SimilarQuestionCount
- ConfidenceLevel
- LastSeenAt

**Purpose**
Supports product behaviors such as “other learners asked this too.”

---

### 3.15 AssessmentBlueprint
Represents the configuration of an assessment.

**Attributes**
- Id
- ScopeType
- ScopeId
- CreatedByUserId
- OwnerType
- TotalQuestionCount
- MultipleChoiceCount
- DescriptiveCount
- DurationMinutes
- UsesStepWeights
- Status
- CreatedAt

**ScopeType**
- LearningStep
- LearningPath

---

### 3.16 AssessmentBlueprintStepWeight
Represents step weights used in a path-level assessment blueprint.

**Attributes**
- Id
- BlueprintId
- LearningPathStepId
- Weight

---

### 3.17 GeneratedAssessment
Represents a generated assessment instance for one specific user.

**Attributes**
- Id
- BlueprintId
- UserId
- GenerationContextReference
- Status
- GeneratedAt
- DurationMinutes
- StartedAt
- SubmittedAt
- AutoSubmittedAt

---

### 3.18 AssessmentQuestion
Represents a generated question.

**Attributes**
- Id
- GeneratedAssessmentId
- Order
- QuestionType
- Statement
- Points
- ExpectedAnswer
- Rubric
- CreatedAt

**QuestionType**
- MultipleChoice
- Descriptive

---

### 3.19 AssessmentQuestionOption
Represents an option for an MCQ question.

**Attributes**
- Id
- QuestionId
- Order
- Text
- IsCorrect

---

### 3.20 AssessmentQuestionSource
Represents the content grounding of a generated question.

**Attributes**
- Id
- QuestionId
- ContentChunkId
- KnowledgeItemId
- RelevanceScore

---

### 3.21 AssessmentAttempt
Represents one actual execution of a generated assessment.

**Attributes**
- Id
- GeneratedAssessmentId
- UserId
- Status
- StartedAt
- SubmittedAt
- AutoSubmittedAt
- Score
- MaxScore

---

### 3.22 AssessmentAnswer
Represents a user answer to a question.

**Attributes**
- Id
- AttemptId
- QuestionId
- SelectedOptionId
- DescriptiveAnswerText
- AnsweredAt

---

### 3.23 AssessmentEvaluation
Represents the final evaluation of an attempt.

**Attributes**
- Id
- AttemptId
- EvaluatedAt
- TotalScore
- MaxScore
- Percentage
- SummaryFeedback

---

### 3.24 AssessmentQuestionEvaluation
Represents the evaluation of one question.

**Attributes**
- Id
- EvaluationId
- QuestionId
- Score
- MaxScore
- Feedback

---

### 3.25 LearningPathAnalyticsSnapshot
Represents the current analytical state of a path.

**Attributes**
- Id
- LearningPathId
- StartedUsersCount
- CompletedUsersCount
- CompletionRate
- AverageCompletionTime
- MedianCompletionTime
- PaceFastCount
- PaceNormalCount
- PaceSlowCount
- UpdatedAt

---

### 3.26 LearningStepAnalyticsSnapshot
Represents the current analytical state of a step.

**Attributes**
- Id
- StepId
- StartedUsersCount
- CompletedUsersCount
- CompletionRate
- AverageTimeSpent
- MedianTimeSpent
- DropOffCount
- CommonQuestionCount
- UpdatedAt

---

### 3.27 UserLearningBenchmark
Represents a benchmarked analytical view of a user’s progress.

**Attributes**
- Id
- UserLearningPathId
- CurrentPaceClassification
- CommunityPercentile
- ComparedToExpectedProfile
- UpdatedAt

---

## 4. Relationships

- KnowledgeItem -> IngestionJob : one-to-many
- IngestionProfile -> IngestionJob : one-to-many
- IngestionJob -> ContentChunk : one-to-many
- ContentChunk -> ChunkEmbedding : one-to-many or one-to-one current representation
- LearningPath -> LearningPathStep : one-to-many
- LearningPathStep -> LearningStepContent : one-to-many
- KnowledgeItem -> LearningStepContent : one-to-many
- LearningPath -> UserLearningPath : one-to-many
- UserLearningPath -> UserLearningStepProgress : one-to-many
- ChatSession -> ChatMessage : one-to-many
- AssessmentBlueprint -> AssessmentBlueprintStepWeight : one-to-many
- AssessmentBlueprint -> GeneratedAssessment : one-to-many
- GeneratedAssessment -> AssessmentQuestion : one-to-many
- AssessmentQuestion -> AssessmentQuestionOption : one-to-many
- AssessmentQuestion -> AssessmentQuestionSource : one-to-many
- GeneratedAssessment -> AssessmentAttempt : one-to-one in MVP, extensible later
- AssessmentAttempt -> AssessmentAnswer : one-to-many
- AssessmentAttempt -> AssessmentEvaluation : one-to-one
- AssessmentEvaluation -> AssessmentQuestionEvaluation : one-to-many
- LearningPath -> LearningPathAnalyticsSnapshot : one current snapshot
- LearningPathStep -> LearningStepAnalyticsSnapshot : one current snapshot
- UserLearningPath -> UserLearningBenchmark : one current benchmark snapshot

---

## 5. Core Business Rules

### Knowledge Rules
- A content item exists independently from any path.
- Content must be reusable.
- File-backed content must remain downloadable.
- PDF is a first-class content source.
- AI-rich operations should rely on ingest-ready content.

### Ingestion Rules
- Every ingestion execution should be traceable to a profile.
- Chunking configuration must be traceable.
- Chunks must preserve source offsets or boundaries where possible.
- Embeddings must remain linked to chunks.

### Learning Rules
- Paths are step-based.
- Paths and steps are time-aware.
- Fast / Normal / Slow expected durations are required.
- Paths may be public or private.
- Public paths are enrollable.

### Progress Rules
- Progress exists in the context of enrollment.
- Step progress must include StartedAt.
- Pace comparison must be possible.

### Interaction Rules
- Chat must be scoped.
- Answers should be grounded in real content/chunks.
- Common-question signals should be data-backed.

### Assessment Rules
- Assessment scope must be explicit.
- Generated assessments are per-user.
- Path-level assessments may use step weights.
- Question generation should be grounded to content/chunks.
- Descriptive grading is AI-assisted.

### Analytics Rules
- Path analytics must support completion and timing insights.
- Step analytics must support timing and question signals.
- User benchmark must support expectation-based and community-based comparison.