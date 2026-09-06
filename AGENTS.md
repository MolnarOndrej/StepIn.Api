# Agent Instructions

## Git conventions

All branches, commits, and pull requests must reference the corresponding Plane work item.

Use the Plane work item identifier, for example `STEPI-13`, consistently throughout the Git workflow.

### Branches

Use:

`<type>/<ticket-id>-<short-description>`

Examples:

`feat/STEPI-20-add-user-registration`
`fix/STEPI-21-fix-login-error`
`chore/STEPI-23-update-dependencies`

The ticket ID must match the corresponding Plane work item.

### Commits

Use:

`<TICKET-ID> <short description>`

Example:

`STEPI-9 Initialize .gitignore`

Start the commit message with the Plane work item ID whenever the commit belongs to a work item.

### Pull requests

Use:

`[<TICKET-ID>] <work item title or short description>`

Example:

`[STEPI-9] Initialize StepIn API repository`

The Plane work item ID must be enclosed in square brackets in the pull request title.

Do not use:

`STEPI-9 Initialize StepIn API repository`

Use:

`[STEPI-9] Initialize StepIn API repository`

Whenever possible, use the Plane work item title as the pull request title after the ticket ID.
