#!/usr/bin/env bash
# Check the Price Now – cURL example
# Usage: WALTRACK_API_KEY=your-key bash check_product.sh
set -euo pipefail

curl -sS --fail-with-body -X POST -G "https://www.waltrack.dev/api/v1/products/8f0b3c7e-2a4d-4e51-9c1a-6d2f1b9e7a30/check" \
  -H "Authorization: Bearer ${WALTRACK_API_KEY}" \
  --data-urlencode wait=true
