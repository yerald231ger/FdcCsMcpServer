#!/bin/bash

# Configure the remote repository if not already set
git remote -v | grep -q "origin.*FdcCsMcpServer" || git remote add origin https://github.com/yerald231ger/FdcCsMcpServer.git

# Add the README.md file to the staging area
git add README.md

# Commit the changes with a descriptive message
git commit -m "Add comprehensive README.md with MCP documentation"

# Push the changes to the remote repository
# Using -u to set up tracking if this is the first push to this branch
git push -u origin main || git push -u origin master

echo "Changes pushed successfully to GitHub repository: https://github.com/yerald231ger/FdcCsMcpServer.git"
