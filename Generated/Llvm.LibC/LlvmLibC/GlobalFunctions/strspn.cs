using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strspn
{
	public unsafe static long Invoke(void* src, void* segment)
	{
		void* ptr = null;
		cpp_array_jgy3xh cpp_array_jgy3xh2 = default(cpp_array_jgy3xh);
		void* ptr2 = src;
		void* ptr3 = segment;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = ptr2;
		llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh2);
		unchecked
		{
			sbyte* ptr4 = (sbyte*)(&cpp_array_jgy3xh2);
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			((long*)ptr4)[2] = -6148914691236517206L;
			((long*)ptr4)[3] = -6148914691236517206L;
			bitset_256ul_Constructor.Invoke(&cpp_array_jgy3xh2);
			for (; *(bool*)ptr3; ptr3 = (byte*)ptr3 + 1)
			{
				bitset_256ul_set.Invoke(&cpp_array_jgy3xh2, (byte)(*(sbyte*)ptr3));
			}
			for (; *(bool*)ptr2 && bitset_256ul_test.Invoke(&cpp_array_jgy3xh2, (byte)(*(sbyte*)ptr2)); ptr2 = (byte*)ptr2 + 1)
			{
			}
			long result = (long)ptr2 - (long)ptr;
			llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
