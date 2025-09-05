# Data Model for Taskify

## User
- id: Guid
- name: string
- role: enum (ProductManager, Engineer)

## Project
- id: Guid
- name: string
- tasks: List<Task>

## Task
- id: Guid
- projectId: Guid
- title: string
- description: string
- status: enum (ToDo, InProgress, InReview, Done)
- assignedUserId: Guid
- comments: List<Comment>

## Comment
- id: Guid
- taskId: Guid
- authorUserId: Guid
- content: string
- timestamp: DateTime
