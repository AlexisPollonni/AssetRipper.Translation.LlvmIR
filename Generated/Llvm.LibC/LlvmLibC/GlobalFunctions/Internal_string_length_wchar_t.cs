using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_string_length_wchar_t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal13string_lengthIwEEmPKT_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::string_length<wchar_t>(wchar_t const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("src")][NativeType("wchar_t const*")] void* Src)
	{
		long num = 0L;
		void* ptr = Src;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = 0L;
		unchecked
		{
			while (*(int*)ptr != 0)
			{
				ptr = (byte*)ptr + 4;
				num++;
			}
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
