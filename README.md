# Git Commit Convention

## 1. 기본 형식
```
<type>(<scope>): <subject>

[optional body]

[optional footer]
```

## 2. 예시
```
fix(bug): resolve infinite enemy spawning issue

Corrected the enemy spawner script where enemies were continuously
spawning even after the wave was completed.
Ensures proper wave progression.

Fixes #BUG-101
```

## 3. 타입(type) - 필수
- `feat`: 새로운 기능 추가
- `fix`: 버그 수정
- `docs`: 문서 수정
- `style`: 코드 스타일 변경 (코드 변경 없음)
- `refactor`: 코드 리팩토링 (기능 변경 없음)
- `perf`: 성능 개선
- `test`: 테스트 코드 추가 또는 수정
- `build`: 빌드 시스템 또는 외부 종속성 변경
- `ci`: CI/CD 관련 변경
- `chore`: 기타 변경사항 (예: 빌드 스크립트 수정, 패키지 업데이트 등)
- `revert`: 이전 커밋 되돌리기
- `release`: 배포 관련 커밋

## 4. 스코프(scope) - 선택 사항
- 변경 사항이 영향을 미치는 모듈이나 파일 명시
- 예시: `bug`, `api`, `ui`, `config`

## 5. 서브젝트 (subject) - 필수
- 변경 사항을 50자 이내로 간결하게 설명
- 첫 글자는 소문자로 시작하며, 마침표는 사용하지 않습니다.
- 명령형 동사로 시작해야 합니다. (예시: "add", "fix", "update")

## 6. 바디(body) - 선택 사항
- 변경 사항에 대한 자세한 설명
- 문단은 빈줄로 구분하며, 50-72자 내외로 작성합니다.

## 7. 푸터(footer) - 선택 사항
- 이슈 트래커 연결 참조
- 예시: `Closes #123`, `Fixes #456`