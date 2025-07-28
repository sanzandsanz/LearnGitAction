# Github Action


Git Hub Runners: https://github.com/actions/runner-images


Here is the first GitHub Workflow that contains two steps (two tasks)

1. To print Hello World 
2. To print Done See yaa

This workflow has a workflow_dispatch event trigger i.e. it won't trigger automatically. It should be manually trigger. 
```
name: Sanjay First Workflow
on: workflow_dispatch
jobs: 
  my-first-job: 
    runs-on: ubuntu-latest
    steps: 
      - name: Print greeting
        run: echo "Hello World"q
      - name: Print goodby
        run: echo "Done See yaa!!"
```

Github Workflows Triggers:
https://docs.github.com/en/actions/reference/workflows-and-actions/events-that-trigger-workflows


# Github Actions

There are different github actions that you can use in your workflow. For example: If you want to checkout the code from the repository, you can use the `actions/checkout@v2` action.

https://github.com/actions/checkout

