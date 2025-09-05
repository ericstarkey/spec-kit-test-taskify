# Tasks: Create Taskify

**Input**: Design documents from `/specs/001-develop-taskify-a/`
**Prerequisites**: plan.md (required), research.md, data-model.md

## Execution Flow (main)
```
1. Load plan.md from feature directory
2. Load optional design documents: data-model.md, research.md, quickstart.md
3. Generate tasks by category: setup, tests, core, integration, polish
4. Apply task rules: parallel [P] where possible, TDD order
5. Number tasks sequentially (T001, T002...)
6. Validate task completeness
```

## Phase 3.1: Setup
- [x] T001 Create backend/ and frontend/ project structure per plan.md
- [x] T002 Initialize .NET Aspire solution with Blazor Server frontend and API backend
- [x] T003 [P] Configure PostgreSQL 15+ and connection strings for local development
- [x] T004 [P] Add Entity Framework Core 8+ and Npgsql dependencies to backend
- [x] T005 [P] Set up linting and formatting tools for C# and Blazor

## Phase 3.2: Tests First (TDD)
	- ~~T006: Write failing contract test for Project API endpoint (POST /api/projects)~~ ✅
	- ~~T007: Write failing contract test for Task API endpoint (POST /api/tasks)~~ ✅
	- ~~T008: Write failing contract test for Notification API endpoint (POST /api/notifications)~~ ✅
	- ~~T009: Write failing integration test for Kanban board drag-and-drop~~ ✅
	- ~~T010: Write failing integration test for SignalR real-time updates~~ ✅
	- ~~T011: Write failing integration test for user assignment and task highlighting~~ ✅
	- ~~T012: Write failing integration test for comment add/edit/delete~~ ✅

## Phase 3.3: Core Implementation
	- ~~T013: Implement User model in backend/src/models/User.cs~~ ✅
	- ~~T014: Implement Project model in backend/src/models/Project.cs~~ ✅
	- ~~T015: Implement Task model in backend/src/models/Task.cs~~ ✅
	- ~~T016: Implement Comment model in backend/src/models/Comment.cs~~ ✅
	- ~~T017: Implement ProjectService in backend/src/services/ProjectService.cs~~ ✅
	- ~~T018: Implement TaskService in backend/src/services/TaskService.cs~~ ✅
	- ~~T019: Implement NotificationService in backend/src/services/NotificationService.cs~~ ✅
	- ~~T020: Implement Project API endpoints in backend/src/api/ProjectsController.cs~~ ✅
	- ~~T021: Implement Task API endpoints in backend/src/api/TasksController.cs~~ ✅
	- ~~T022: Implement Notification API endpoints in backend/src/api/NotificationsController.cs~~ ✅
	- ~~T023: Implement Blazor Server Kanban board with drag-and-drop in frontend/src/pages/Kanban.razor~~ ✅
	- ~~T024: Implement real-time updates with SignalR in frontend/src/services/SignalRService.cs~~ ✅
	- ~~T025: Implement user selection and task highlighting in frontend/src/pages/UserSelect.razor~~ ✅
	- ~~T026: Implement comment add/edit/delete UI in frontend/src/components/CommentSection.razor~~ ✅

## Phase 3.4: Integration
- [x] T027 Integrate backend with PostgreSQL using EF Core migrations
- [x] T028 Integrate frontend with backend APIs for projects, tasks, notifications
- [x] T029 Integrate SignalR for real-time Kanban updates
- [x] T030 Add structured logging to backend and frontend

## Phase 3.5: Polish
- [x] T031 [P] Write unit tests for all models and services in backend/tests/unit/
- [x] T032 [P] Write unit tests for Blazor components in frontend/tests/unit/
- [x] T033 [P] Add performance tests for Kanban board and API endpoints
- [x] T034 [P] Update documentation and quickstart.md with any changes

## Parallel Execution Guidance
- Tasks marked [P] can be executed in parallel (different files, no dependencies)
- Example: T003, T004, T005 can be run together after T002
- Example: All contract and integration tests (T006-T012) can be run in parallel after setup

## Dependency Notes
- Setup tasks (T001-T005) must be completed before tests and implementation
- Contract and integration tests (T006-T012) must fail before implementation (TDD)
- Core implementation (T013-T026) depends on models and services being available
- Integration (T027-T030) depends on core implementation
- Polish tasks (T031-T034) can be run in parallel after integration
