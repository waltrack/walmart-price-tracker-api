// Get a Tracked Product – Node.js example (Node 18+, ES module)
// Usage: WALTRACK_API_KEY=your-key node get_product.mjs

const headers = { Authorization: `Bearer ${process.env.WALTRACK_API_KEY}`, "Content-Type": "application/json" };

const params = new URLSearchParams({
  "days": "30",
});
const response = await fetch(`https://www.waltrack.dev/api/v1/products/8f0b3c7e-2a4d-4e51-9c1a-6d2f1b9e7a30?${params}`, { headers });
if (!response.ok) {
  console.error(`HTTP ${response.status}: ${await response.text()}`);
  process.exit(1);
}

console.log(JSON.stringify(await response.json(), null, 2));
