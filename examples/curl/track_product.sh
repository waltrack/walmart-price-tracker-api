#!/usr/bin/env bash
# Track a Product – cURL example
# Usage: WALTRACK_API_KEY=your-key bash track_product.sh
set -euo pipefail

curl -sS --fail-with-body -X POST "https://www.waltrack.dev/api/v1/products" \
  -H "Authorization: Bearer ${WALTRACK_API_KEY}" \
  -H "Content-Type: application/json" \
  --data '{"product": "17835006350", "marketplace": "com", "wait": true}'
