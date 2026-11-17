#!/usr/bin/env bash
# Plan and Remaining Credits – cURL example
# Usage: WALTRACK_API_KEY=your-key bash account.sh
set -euo pipefail

curl -sS --fail-with-body -G "https://www.waltrack.dev/api/v1/account" \
  -H "Authorization: Bearer ${WALTRACK_API_KEY}"
