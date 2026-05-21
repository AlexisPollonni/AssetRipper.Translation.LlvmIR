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
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		int num = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		int num2 = Cxa_atexit.Invoke(Lambda_Void_void.Invoke(&anon_izyfb), null, null);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
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
				Llvm_libc_20_1_2_auxv.Value = ((Anon_5uk363*)This)->field_0;
				((Anon_5uk363*)This)->field_0 = (void*)ulong.MaxValue;
				num3 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
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
