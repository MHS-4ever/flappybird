#!/bin/bash

# Make sure you're inside your Unity project folder before running this

# Step 1: Initialize Git
git init

# Step 2: Create Unity .gitignore if not exists
if [ ! -f ".gitignore" ]; then
    echo "Creating Unity .gitignore..."
    curl -o .gitignore https://raw.githubusercontent.com/github/gitignore/main/Unity.gitignore
else
    echo ".gitignore already exists. Skipping creation."
fi

# Step 3: Add everything
git add .

# Step 4: First commit
git commit -m "Initial Unity project commit"

# Step 5: Ask for remote GitHub repo URL
read -p "Enter your GitHub repository URL: " repo_url
git remote add origin "$repo_url"

# Step 6: Push
git branch -M main
git push -u origin main

echo "✅ Unity project successfully pushed to GitHub!"
