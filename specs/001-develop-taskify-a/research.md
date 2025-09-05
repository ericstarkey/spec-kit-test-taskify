# Research for Taskify Implementation (.NET Aspire, Postgres, Blazor Server)

## .NET Aspire Version
- **Decision**: Use the latest stable release of .NET Aspire as of September 2025.
- **Rationale**: Aspire is rapidly evolving; using the latest stable ensures access to new features and security updates.
- **Alternatives considered**: Pinning to an older LTS version for stability, but this may limit access to new orchestration features needed for real-time and Blazor integration.
- **Action**: Research the latest stable version, breaking changes, and best practices for orchestration, service discovery, and integration with Blazor Server and Postgres.

## Blazor Server Version
- **Decision**: Use Blazor Server as included in .NET 8+.
- **Rationale**: .NET 8+ provides improved SignalR and real-time support, which is critical for drag-and-drop and live Kanban updates.
- **Alternatives considered**: Blazor WebAssembly, but server-side is preferred for real-time and MVP simplicity.
- **Action**: Research any breaking changes or new features in Blazor Server in .NET 8+ relevant to real-time Kanban boards.

## Postgres Version
- **Decision**: Use PostgreSQL 15.x or latest stable supported by Npgsql and .NET Aspire.
- **Rationale**: Ensures compatibility with Entity Framework Core and Aspire orchestration.
- **Alternatives considered**: Older versions for compatibility, but latest stable is preferred for features and performance.
- **Action**: Research compatibility matrix for Npgsql, EF Core, and Aspire with Postgres 15+.

## Entity Framework Core & Npgsql
- **Decision**: Use EF Core 8+ and Npgsql provider compatible with .NET 8+ and Postgres 15+.
- **Rationale**: Ensures up-to-date ORM features and best performance.
- **Action**: Research any known issues or best practices for EF Core 8+ with Aspire and Blazor Server.

## SignalR for Real-Time
- **Decision**: Use SignalR as included in .NET 8+ for real-time Kanban updates.
- **Rationale**: Native integration with Blazor Server and .NET Aspire.
- **Action**: Research best practices for scaling SignalR with Aspire and Postgres-backed state.

## REST API Design
- **Decision**: Use RESTful endpoints for projects, tasks, and notifications.
- **Rationale**: Simplicity and compatibility with future integrations.
- **Action**: Research OpenAPI tooling and contract-first approaches in .NET Aspire.

---

## Parallel Research Tasks
- What is the latest stable version of .NET Aspire as of September 2025? What are the major breaking changes since .NET 8?
- What are the recommended practices for orchestrating Blazor Server and Postgres with Aspire?
- Are there any known issues with EF Core 8+ and Npgsql when used with Aspire and Postgres 15+?
- What are the best practices for implementing real-time drag-and-drop Kanban boards in Blazor Server with SignalR?
- What OpenAPI/contract-first tools are recommended for REST API development in .NET Aspire?

---

## To Do
- [ ] Update this document with findings from each research task above.
- [ ] Pin all major dependencies to specific versions in the implementation plan.
