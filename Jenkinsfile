pipeline {
  agent any
  environment{
     DOTNET_CLI_HOME = "C:\\Program Files\\dotnet"
  }
  stages {
    stage('Checkout') {
       steps {
         checkout scm
       }
     }
     stage('Build') {
       steps {
         bat "dotnet restore"

         bat "dotnet build --configuration Release"
       }
     }
    stage('Test') {
      steps {
        bat "dotnet test --no-restore --configuration Release"
      }
    }
    
    stage('Publish') {
      steps {
        bat "dotnet publish --no-restore --configuration Release --output .\\publish"
      }
    }
    stage('Deploy') {
      environment {
        registryDomain = "registry.hub.docker.com/chipbios/aspdotnetcor"
        registry = "https://${registryDomain}"
        registryCredential = 'docker-credentials'
        PATH = "${dockerHome}/bin:${env.PATH}"
        repo = "test"
        project = "transaction-service"
        version = sh(returnStdout: true, script: 'git rev-parse HEAD').trim()
        fullName = "${registryDomain}/${repo}/${project}"
      }
      steps {
		echo 'Docker packaging..'
        container('docker') {
          script{
            def defaultLatestImage = docker.build("${fullName}", ".")
            def taggedImage = docker.build("${fullName}:${version}", ".")
            docker.withRegistry(registry, registryCredential) {
              defaultLatestImage.push()
              taggedImage.push()
            }
          }
        }
      }
    }
 }

 post {
 success {
   echo 'Build, test, and publish successful!'
 }
}


      
}
