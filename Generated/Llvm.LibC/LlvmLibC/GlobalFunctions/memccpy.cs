using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memccpy
{
	public unsafe static void* Invoke(void* dest, void* src, int c, long count)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = null;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)c;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = src;
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = dest;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < (ulong)count && (byte)((sbyte*)ptr)[num] != (byte)b; num++)
			{
				sbyte b2 = ((sbyte*)ptr)[num];
				((sbyte*)ptr2)[num] = b2;
			}
			void* result;
			if ((ulong)num < (ulong)count)
			{
				sbyte b3 = ((sbyte*)ptr)[num];
				((sbyte*)ptr2)[num] = b3;
				result = (byte*)ptr2 + num + 1;
			}
			else
			{
				result = null;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
