## Unity CI

### High Level Steps
-

### Detailed Steps

1. Get Unity License for github (steps detailed [here](https://game.ci/docs/github/activation#converting-into-a-license))
	1. Init repo with `./github/.workflows/activation.yml`
	2. Manually run action through github
	3. Download license file (an artifact created in github Actions)
	4. Upload license file to https://license.unity3d.com/
	5. Copy contents of file as a github secret (i.e. `UNITY_LICENSE`)
2. Configure desired triggers, file naming conventions, Itch configuration and for `./github/.workflows/build-and-publish.yml`
3. Generate Butler API key (https://itch.io/docs/butler/login.html#running-butler-from-ci-builds-travis-ci-gitlab-ci-etc)
  1. Install Butler
  2. run `butler login`
  3. copy api key
4. Add Butler API key as `BUTLER_CREDENTIALS` github secret