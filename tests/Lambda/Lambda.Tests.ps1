BeforeAll {
    . (Join-Path (Join-Path (Get-Location) "Include") "TestIncludes.ps1")
    . (Join-Path (Join-Path (Get-Location) "Include") "TestHelper.ps1")
    . (Join-Path (Join-Path (Get-Location) "Include") "ServiceTestHelper.ps1")
    $helper = New-Object ServiceTestHelper
    $helper.BeforeAll()
}

AfterAll {
    $helper.AfterAll()
}

Describe -Tag "Smoke" "Lambda" {

    Context "Functions" {

        It "Can list and read functions" {
            $fns = Get-LMFunctions
            if ($fns) {
                $fns.Count | Should -BeGreaterThan 0

                $fn = Get-LMFunction -FunctionName $fns[0].FunctionName

                $fn | Should -Not -Be $null
            }
        }
    }
}
