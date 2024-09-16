# Google Custom Search API Example in C#

This project demonstrates how to extract Google search results using the [Google Custom Search API](https://developers.google.com/custom-search/v1/overview) in C#. We use similar code in our [Google SERP scraper](https://websiteextractor.net/google-scraper/). You can use this script to perform a Google search programmatically and retrieve search results including titles, links, and snippets.

## Prerequisites

Before you begin, you'll need the following:

1. A [Google Custom Search Engine](https://developers.google.com/custom-search/docs/tutorial/introduction) (CSE) set up.
2. An API Key from the [Google Cloud Console](https://console.cloud.google.com/).

## Setup

### Step 1: Create a Google Custom Search Engine (CSE)

1. Go to the [Custom Search JSON API](https://developers.google.com/custom-search/v1/overview).
2. Create a new search engine.
3. Retrieve your **CSE ID**.

### Step 2: Get an API Key

1. Visit the [Google Cloud Console](https://console.cloud.google.com/).
2. Create a new project if needed.
3. Enable the **Custom Search API** for your project.
4. Generate an **API Key** from the "APIs & Services" section.

## Installation

1. Clone or download the repository.

   ```bash
   git clone https://github.com/yourusername/google-custom-search-api-csharp.git
   ```
Open the project in your favorite C# IDE (e.g., Visual Studio).

Install the Newtonsoft.Json package to handle JSON parsing. You can install it via NuGet:

bash
Code kopieren
Install-Package Newtonsoft.Json
Replace YOUR_GOOGLE_API_KEY and YOUR_CSE_ID with your actual API Key and Custom Search Engine ID in the code.

Optionally, replace YOUR_SEARCH_QUERY with the desired search term.
