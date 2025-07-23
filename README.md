# Git Commit Convention

## 1. �⺻ ����
```
<type>(<scope>): <subject>

[optional body]

[optional footer]
```

## 2. ����
```
fix(bug): resolve infinite enemy spawning issue

Corrected the enemy spawner script where enemies were continuously
spawning even after the wave was completed.
Ensures proper wave progression.

Fixes #BUG-101
```

## 3. Ÿ��(type) - �ʼ�
- `feat`: ���ο� ���
- `fix`: ���� ����
- `docs`: ���� ����
- `style`: �ڵ� ��Ÿ�� ���� (�ڵ� ���� ����)
- `refactor`: �ڵ� �����丵 (��� ���� ����)
- `perf`: ���� ����
- `test`: �׽�Ʈ �ڵ� �߰� �Ǵ� ����
- `build`: ���� �ý��� �Ǵ� �ܺ� ���Ӽ� ����
- `ci`: CI/CD ���� ����
- `chore`: ��Ÿ ������� (��: ���� ��ũ��Ʈ ����, ��Ű�� ������Ʈ ��)
- `revert`: ���� Ŀ�� �ǵ�����
- `WIP`: �۾� �� (Work In Progress)
- `release`: ���� ���� Ŀ��

## 4. ������(scope) - ���� ����
- ���� ������ ������ ��ġ�� ����̳� ������ ����մϴ�.
- ��: `bug`, `api`, `ui`, `config`

## 5. ������Ʈ(subject) - �ʼ�
- ���� ������ �����ϰ� �����մϴ�.
- ù ���ڴ� �ҹ��ڷ� �����ϸ�, ��ħǥ�� ������� �ʽ��ϴ�.
- 50�� �̳��� �ۼ��մϴ�.
- ����� ����� �ۼ��մϴ�. (��: "add", "fix", "update")

## 6. �ٵ�(body) - ���� ����
- ���� ���׿� ���� �ڼ��� ������ �ۼ��մϴ�.
- ������ �� �ٷ� �����մϴ�.
- 50�� �̻�, 72�� �̳��� �ۼ��մϴ�.

## 7. Ǫ��(footer) - ���� ����
- �̽� Ʈ��Ŀ�� ������ �� �ִ� ������ �����մϴ�.
- ��: `Closes #123`, `Fixes #456`