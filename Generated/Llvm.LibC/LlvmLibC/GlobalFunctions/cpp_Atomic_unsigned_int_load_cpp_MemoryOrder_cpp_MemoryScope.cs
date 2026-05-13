using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE4loadENS0_11MemoryOrderENS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::load(__llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_int_load_cpp_MemoryOrder_cpp_MemoryScope
{
	public unsafe static int Invoke(void* @this, MemoryOrder mem_ord, MemoryScope mem_scope)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		unchecked
		{
			void* ptr = cpp_Atomic_unsigned_int_addressof_unsigned_int.Invoke(&((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
			int num2 = cpp_Atomic_unsigned_int_order_cpp_MemoryOrder.Invoke(mem_ord);
			int num3 = cpp_Atomic_unsigned_int_scope_cpp_MemoryScope.Invoke(mem_scope);
			void* ptr2 = cpp_Atomic_unsigned_int_addressof_unsigned_int.Invoke(&num);
			switch (num2)
			{
			default:
			{
				int num6 = num3;
				if (num6 != 1)
				{
					if (num6 != 2)
					{
						if (num6 != 3)
						{
							if (num6 != 4)
							{
								*(int*)ptr2 = *(int*)ptr;
							}
							else
							{
								*(int*)ptr2 = *(int*)ptr;
							}
						}
						else
						{
							*(int*)ptr2 = *(int*)ptr;
						}
					}
					else
					{
						*(int*)ptr2 = *(int*)ptr;
					}
				}
				else
				{
					*(int*)ptr2 = *(int*)ptr;
				}
				break;
			}
			case 1:
			case 2:
			{
				int num5 = num3;
				if (num5 != 1)
				{
					if (num5 != 2)
					{
						if (num5 != 3)
						{
							if (num5 != 4)
							{
								*(int*)ptr2 = *(int*)ptr;
							}
							else
							{
								*(int*)ptr2 = *(int*)ptr;
							}
						}
						else
						{
							*(int*)ptr2 = *(int*)ptr;
						}
					}
					else
					{
						*(int*)ptr2 = *(int*)ptr;
					}
				}
				else
				{
					*(int*)ptr2 = *(int*)ptr;
				}
				break;
			}
			case 5:
			{
				int num4 = num3;
				if (num4 != 1)
				{
					if (num4 != 2)
					{
						if (num4 != 3)
						{
							if (num4 != 4)
							{
								*(int*)ptr2 = *(int*)ptr;
							}
							else
							{
								*(int*)ptr2 = *(int*)ptr;
							}
						}
						else
						{
							*(int*)ptr2 = *(int*)ptr;
						}
					}
					else
					{
						*(int*)ptr2 = *(int*)ptr;
					}
				}
				else
				{
					*(int*)ptr2 = *(int*)ptr;
				}
				break;
			}
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
