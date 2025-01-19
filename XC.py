<!-- app.component.html -->
<div class="converter">
  <h1 class="animated">Розширений конвертер метрів</h1>
  <div class="tooltip">
    <span>ℹ️</span>
    <span class="tooltiptext">Введіть значення у метрах і виберіть одиниці для конвертації</span>
  </div>
  <input
    type="number"
    [(ngModel)]="meters"
    placeholder="Введіть кількість метрів"
  />
  <select [(ngModel)]="conversion">
    <option *ngFor="let option of conversions" [value]="option.value">
      {{ option.label }}
    </option>
  </select>
  <button (click)="convert()">Конвертувати</button>
  <div class="result">{{ result }}</div>
  <footer>© 2025 Розширений конвертер. Всі права захищено.</footer>
</div>