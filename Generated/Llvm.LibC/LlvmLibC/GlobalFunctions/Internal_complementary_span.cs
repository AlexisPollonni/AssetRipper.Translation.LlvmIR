using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_complementary_span
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18complementary_spanEPKcS2_")]
	[DemangledName("__llvm_libc_20_1_2_::internal::complementary_span(char const*, char const*)")]
	public unsafe static long Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("segment")][NativeType("char const*")] void* Segment)
	{
		void* ptr = null;
		Cpp_array_jgy3xh cpp_array_jgy3xh = default(Cpp_array_jgy3xh);
		void* ptr2 = Src;
		void* ptr3 = Segment;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = ptr2;
		Llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh);
		unchecked
		{
			sbyte* ptr4 = (sbyte*)(&cpp_array_jgy3xh);
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			((long*)ptr4)[2] = -6148914691236517206L;
			((long*)ptr4)[3] = -6148914691236517206L;
			Bitset_256ul_Constructor.Invoke(&cpp_array_jgy3xh);
			for (; *(bool*)ptr3; ptr3 = (byte*)ptr3 + 1)
			{
				Bitset_256ul_set.Invoke(&cpp_array_jgy3xh, (byte)(*(sbyte*)ptr3));
			}
			for (; *(bool*)ptr2 && InstructionHelper.BooleanXor(Bitset_256ul_test.Invoke(&cpp_array_jgy3xh, (byte)(*(sbyte*)ptr2)), right: true); ptr2 = (byte*)ptr2 + 1)
			{
			}
			long result = (long)ptr2 - (long)ptr;
			Llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
