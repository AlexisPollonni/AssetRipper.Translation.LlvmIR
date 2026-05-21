using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strrchr_implementation_vj8pat
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL22strrchr_implementationEPKci")]
	[DemangledName("__llvm_libc_20_1_2_::internal::strrchr_implementation(char const*, int)")]
	[CleanName("Internal_strrchr_implementation")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("c")][NativeType("int")] int C)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = Src;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)C;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = null;
			while (true)
			{
				if (*(sbyte*)ptr2 == b)
				{
					ptr = ptr2;
				}
				if (*(sbyte*)ptr2 == 0)
				{
					break;
				}
				ptr2 = (byte*)ptr2 + 1;
			}
			void* result = ptr;
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
