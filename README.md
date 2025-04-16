# Contributing Guidelines

## 🔹 Project Flow Chart
[View Flow Chart](https://www.canva.com/design/DAGkyrPO5nI/_BQfT7yNz2cGKoukrkZ3OQ/edit?utm_content=DAGkyrPO5nI&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)

##

if there are compability issues download kripton.Toolkit in manage <nuget> then restart the microsoft studio  

Thank you for your interest in contributing! Follow the steps below to contribute effectively.

## 🔹 Forking the Repository
1. Click the **Fork** button on the repository page.

## 🔹 Contributing via Cloning

### 1️⃣ Clone the Repository
Run the following command to clone the forked repository to your local machine:
```sh
git clone <your-forked-repo-url>
```

### 2️⃣ Make Changes and Commit
1. Check the status of your changes:
   ```sh
   git status
   ```
2. If files appear in **red**, stage them:
   ```sh
   git add .
   ```
3. If files appear in **green**, commit them with a message:
   ```sh
   git commit -m "Your commit message"
   ```
4. Push the changes to your forked repository:
   ```sh
   git push
   ```

### 3️⃣ Create a Pull Request
1. Go to your forked repository on GitHub.
2. Click **"This branch is # commits ahead"**.
3. Click the **"Create Pull Request"** button.
4. Fill in the details and submit the pull request.

---

## 🔹 Contributing via Adding a File

### 1️⃣ Upload a File via GitHub
1. Go to your forked repository on GitHub.
2. Click **"Add file" → "Upload files"**.
3. Drag and drop or select your file(s).
4. Add a commit message.
5. Click **"Commit changes"**.

### 2️⃣ Create a Pull Request
Follow the same steps as mentioned in the **Create a Pull Request** section above.

---

## 🔹 Keeping Your Fork Updated

### 1️⃣ Sync Your Fork
1. Go to your forked repository on GitHub.
2. Click the **"Sync Fork"** button.
3. Click **"Update Branch"** (if available).

### 2️⃣ Update Your Local Clone
Run the following command to check your remote repositories:
```sh
git remote -v
```
To fetch and merge the latest changes:
```sh
git fetch upstream  
git merge upstream/main  # or the appropriate branch
```

