param([string]$Python = 'python')
$ErrorActionPreference = 'Stop'
# Conversion only. This wrapper does not build, launch an engine or run tests.
& $Python (Join-Path $PSScriptRoot 'import_full_forge.py')
if ($LASTEXITCODE -ne 0) { throw 'Full Forge conversion failed. Existing manifest remains the integrity checkpoint.' }
& node (Join-Path $PSScriptRoot 'build-table-index.mjs')
if ($LASTEXITCODE -ne 0) { throw 'Failed to rebuild the in-game card directory for the imported manifest.' }
