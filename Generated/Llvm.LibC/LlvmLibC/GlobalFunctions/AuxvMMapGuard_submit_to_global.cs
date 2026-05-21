using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_submit_to_global
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13AuxvMMapGuard16submit_to_globalEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::submit_to_global()")]
	public unsafe static void Invoke(void* @this)
	{
		int num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		int num2 = cxa_atexit.Invoke(lambda_void_void.Invoke(&anon_izyfb8), null, null);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		num = num2;
		unchecked
		{
			int num3;
			if (num != 0)
			{
				num3 = 1;
			}
			else
			{
				auxv.Value = ((anon_5uk363*)@this)->field_0;
				((anon_5uk363*)@this)->field_0 = (void*)ulong.MaxValue;
				num3 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			switch (num3)
			{
			case 0:
			case 1:
				return;
			}
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
